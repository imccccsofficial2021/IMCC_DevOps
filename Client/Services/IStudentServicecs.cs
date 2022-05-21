namespace MudBlazorWASM.Client.Services
{
    public interface IStudentService
    {
        List<StudentList> Students { get; set; }

        Task GetStudent();

        // Task GetSingleStudent(int id);
        Task<StudentList> GetSingleStudent(int id);
        Task DeleteStudent(int id);
        Task UpdateStudent(StudentList student);
        Task CreateStudent(StudentList student);
        
    }
}

