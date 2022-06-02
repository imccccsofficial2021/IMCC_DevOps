namespace MudBlazorWASM.Client.Services
{
    public interface IStudentService
    {
        List<Student> Students { get; set; }

        Task GetStudent();

        // Task GetSingleStudent(int id);
        Task<Student> GetSingleStudent(int id);
        Task DeleteStudent(int id);
        Task UpdateStudent(Student student);
        Task CreateStudent(Student student);
        
    }
}

