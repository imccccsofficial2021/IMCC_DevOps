namespace MudBlazorWASM.Client.Services.EnrollmentServices
{
    public interface IEnrollmentS
    {
        List<Admission> Enrolls { get; set; }

        Task GetEnrollments();

        // Task GetSingleStudent(int id);
        Task<Admission> GetSingleEnrollment(int id);
        Task DeleteEnrollment(int id);
        Task UpdateEnrollment(Admission student);
        Task CreateEnrollment(Admission student);
    }
}
