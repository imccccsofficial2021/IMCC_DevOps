using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MudBlazorWASM.Client.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public StudentService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<StudentList> Students { get; set; } = new List<StudentList>();


        public async Task CreateStudent(StudentList student)
        {
            var result = await _http.PostAsJsonAsync("api/student", student);
            await SetStudents(result);
        }
        public async Task<StudentList> GetSingleStudent(int id)
        {
            var result = await _http.GetFromJsonAsync<StudentList>($"api/student/{id}");
            if (result != null)
                return result;
            throw new Exception("Student Not Found");
        }
        public async Task DeleteStudent(int id)
        {
            var result = await _http.DeleteAsync($"api/student/{id}");
            await SetStudents(result);
        }

        private async Task SetStudents(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<StudentList>>();
            Students = response;
            _navigationManager.NavigateTo("students");
        }

        public async Task GetStudent()
        {
            var result = await _http.GetFromJsonAsync<List<StudentList>>("api/student/GetStudent");
            if (result != null)
                Students = result;
        }

        public async Task UpdateStudent(StudentList student)
        {
            var result = await _http.PutAsJsonAsync($"api/student/{student.STUDNO}", student);
            await SetStudents(result);
        }

     
    }
}
