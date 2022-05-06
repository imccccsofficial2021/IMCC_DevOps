using Microsoft.AspNetCore.Components;
using MudBlazorWASM.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace MudBlazorWASM.Client.Repository.Grades
{
    public class GradeServices : IGradeServices
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;
        public GradeServices(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }
        public HashSet<GradeSummary> GetListGrades { get; set; } = new();

        public async Task CreateGrade(GradeSummary grade)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/grades/AddNewGrade", grade);
            await SetGrades(result);

        }


        public async Task DeleteGrade(GradeSummary grade)
        {
            var result = await _httpClient.DeleteAsync($"api/grades/{grade}");
            await SetGrades(result);
        }

        public async Task<GradeSummary> GetGradeItemAsync(string studentId)
        {
            var result = await _httpClient.GetFromJsonAsync<GradeSummary>($"api/grades/{studentId}");
            if (result != null)
                return result;
            throw new Exception("Student details not found!");
        }

        public async Task GetGradeSummary()
        {
            var result = await _httpClient.GetFromJsonAsync<HashSet<GradeSummary>>("api/grades");
            if (result != null)
                GetListGrades = result;
        }

        public async Task UpdateGrade(GradeSummary grade)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/grades/{grade.Studno}", grade);
            await SetGrades(result);
        }

        private async Task SetGrades(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<HashSet<GradeSummary>>();
            GetListGrades = response;
            _navigationManager.NavigateTo("egrades");
        }
    }
}