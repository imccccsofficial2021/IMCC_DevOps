namespace MudBlazorWASM.Client.Services.EnrollmentServices
{
    public interface IEnrollmentS
    {
        List<Enrollment> Enrolls { get; set; }

        Task GetEnrollments();

        // Task GetSingleStudent(int id);
        Task<Enrollment> GetSingleEnrollment(int id);
        Task DeleteEnrollment(int id);
        Task UpdateEnrollment(Enrollment student);
        Task CreateEnrollment(Enrollment student);
    }
}
