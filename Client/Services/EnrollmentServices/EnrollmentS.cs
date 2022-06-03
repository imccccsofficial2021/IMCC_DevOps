using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MudBlazorWASM.Client.Services.EnrollmentServices
{
    public class EnrollmentS : IEnrollmentS
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public EnrollmentS(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Admission> Enrolls { get; set; }

        private async Task SetEnrollment(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Admission>>();
            Enrolls = response;
            _navigationManager.NavigateTo("enrollments");
        }

        public async Task CreateEnrollment(Admission enr)
        {
            var result = await _http.PostAsJsonAsync("api/enrollment", enr);
            await SetEnrollment(result);
        }

        public async Task DeleteEnrollment(int id)
        {
            var result = await _http.DeleteAsync($"api/enrollment/{id}");
            await SetEnrollment(result);
        }

        public async Task GetEnrollments()
        {
            var result = await _http.GetFromJsonAsync<List<Admission>>("api/enrollment/GetEnrollment");
            if (result != null)
                Enrolls = result;
        }

        public async Task<Admission> GetSingleEnrollment(int id)
        {
            var result = await _http.GetFromJsonAsync<Admission>($"api/enrollment/{id}");
            if (result != null)
                return result;
            throw new Exception("Enrollment Not Found");
        }

        public async Task UpdateEnrollment(Admission enr2)
        {
            var result = await _http.PutAsJsonAsync($"api/enrollment/{enr2.Enrid}", enr2);
            await SetEnrollment(result);
        }
    }

}
