using Microsoft.AspNetCore.Components;
using MudBlazorWASM.Shared.Models;
using System.Net.Http.Json;

namespace MudBlazorWASM.Server.Services
{
    public class GradeService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public GradeService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<GradeSummary> AllGrades { get; set; } = new List<GradeSummary>();

        public async Task GetAllGrades()
        {
            //return AllGrades.ToList();
            // _navigationManager.NavigateTo("egrades");
            var result = await _http.GetFromJsonAsync<List<GradeSummary>>("api/grades/GetAllGrades");
            if (result != null)
                AllGrades = result;
        }

        public async Task<GradeSummary> GetStudentID(int offerno)
        {
            var studno = await _http.GetFromJsonAsync<GradeSummary>("api/grades/{offerno}");
            if (studno != null)
                return studno;
            throw new Exception("Student Details Not Found!");

        }

        public async Task DeleteGradesByOfferNo(int offerno)
        {
            var result = await _http.DeleteAsync($"api/grades/{offerno}");
            await SetGrades(result);
        }

        public async Task UpdateGradesByStudNo(string studNo)
        {

        }

        private async Task SetGrades(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<GradeSummary>>();
            AllGrades = response;
            _navigationManager.NavigateTo("egrades");
        }



    }
}
