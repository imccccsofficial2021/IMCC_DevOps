
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
        public List<SubjectList> subject { get; set; } = new List<SubjectList>();


        public async Task CreateNewSubjects(SubjectList subjectlist)
        {
            var result = await _http.PostAsJsonAsync("api/subjects", subjectlist);
            await SetSubjects(result);
        }
        public async Task<SubjectList> GetCourseNo(int id)
        {
            var result = await _http.GetFromJsonAsync<SubjectList>($"api/subjects/{id}");
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
            var response = await result.Content.ReadFromJsonAsync<List<SubjectList>>();
            subject = response;
            _navigationManager.NavigateTo("subjects1");
        }

        public async Task GetAllSubject()
        {
            //return AllGrades.ToList();
            // _navigationManager.NavigateTo("egrades");
            var result = await _http.GetFromJsonAsync<List<SubjectList>>("api/subjects/GetAllSubjects");
            if (result != null)
                subject = result;
        }

        public async Task UpdateAllSubjects(SubjectList subjectlist)
        {
            var result = await _http.PutAsJsonAsync($"api/subjects/{subjectlist.ID}", subjectlist);
            await SetSubjects(result);
        }
    }
}
