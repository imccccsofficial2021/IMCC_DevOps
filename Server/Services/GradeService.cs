using Microsoft.AspNetCore.Components;

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

        public List<SubmittedGrade> AllGrades { get; set; } = new List<SubmittedGrade>();

        public async Task GetAllGrades()
        {
            //return AllGrades.ToList();
            // _navigationManager.NavigateTo("egrades");
            var result = await _http.GetFromJsonAsync<List<SubmittedGrade>>("api/grades/GetAllGrades");
            if (result != null)
                AllGrades = result;
        }

        public async Task<SubmittedGrade> GetStudentID(int offerno)
        {
            var studno = await _http.GetFromJsonAsync<SubmittedGrade>("api/grades/{offerno}");
            if (studno != null)
                return studno;
            throw new Exception("Student Details Not Found!");

        }

        public async Task DeleteGradesByOfferNo(int offerno)
        {
            var result = await _http.DeleteAsync($"api/grades/{offerno}");
            await SetGrades(result);
        }

        private async Task SetGrades(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SubmittedGrade>>();
            AllGrades = response;
            _navigationManager.NavigateTo("egrades");
        }



    }
}
