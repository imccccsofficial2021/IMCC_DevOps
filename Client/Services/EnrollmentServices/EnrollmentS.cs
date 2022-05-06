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

        public List<Enrollment> Enrolls { get; set; }

        private async Task SetEnrollment(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Enrollment>>();
            Enrolls = response;
            _navigationManager.NavigateTo("enrollments");
        }

        public async Task CreateEnrollment(Enrollment enr)
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
            var result = await _http.GetFromJsonAsync<List<Enrollment>>("api/enrollment/GetEnrollment");
            if (result != null)
                Enrolls = result;
        }

        public async Task<Enrollment> GetSingleEnrollment(int id)
        {
            var result = await _http.GetFromJsonAsync<Enrollment>($"api/enrollment/{id}");
            if (result != null)
                return result;
            throw new Exception("Enrollment Not Found");
        }

        public async Task UpdateEnrollment(Enrollment enr2)
        {
            var result = await _http.PutAsJsonAsync($"api/enrollment/{enr2.ItemNo}", enr2);
            await SetEnrollment(result);
        }
    }

}
