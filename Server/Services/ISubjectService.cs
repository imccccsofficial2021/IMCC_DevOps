namespace MudBlazorWASM.Server.Services
{
    public interface ISubjectService
    {
        List<Subject> GettingSubjects { get; set; }

        Task GetAllSubject();
        Task CreateNewSubjects(Subject subjectlist);
        Task<Subject> GetCourseNo(int id);
        Task DeleteSubject(int id);
        Task UpdateAllSubjects(Subject subjectlist, int id);
    }
}
