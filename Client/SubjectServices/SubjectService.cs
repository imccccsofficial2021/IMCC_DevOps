
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MudBlazorWASM.Client.SubjectServices
{
    public class SubjectService : ISubjectService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public SubjectService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        // public List<SubjectList> AllSubjects { get; set; } = new List<SubjectList>();
        public List<Subject> Subject { get; set; } = new List<Subject>();


        public async Task CreateNewSubjects(Subject subjectlist)
        {
            var result = await _http.PostAsJsonAsync("api/subjects", subjectlist);
            await SetSubjects(result);
        }
        public async Task<Subject> GetCourseNo(int id)
        {
            var result = await _http.GetFromJsonAsync<Subject>($"api/subjects/{id}");
            if (result != null)
                return result;
            throw new Exception("Subject Details Not Found!");

        }

        public async Task DeleteSubject(int id)
        {
            var result = await _http.DeleteAsync($"api/subjects/{id}");
            await SetSubjects(result);
        }

        private async Task SetSubjects(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Subject>>();
            Subject = response;
            _navigationManager.NavigateTo("subjects1");
        }

        public async Task GetAllSubject()
        {
            //return AllGrades.ToList();
            // _navigationManager.NavigateTo("egrades");
            var result = await _http.GetFromJsonAsync<List<Subject>>("api/subjects/GetAllSubjects");
            if (result != null)
                Subject = result;
        }

        public async Task UpdateAllSubjects(Subject subjectlist)
        {
            var result = await _http.PutAsJsonAsync($"api/subjects/{subjectlist.Coursecode}", subjectlist);
            await SetSubjects(result);
        }
    }
}
