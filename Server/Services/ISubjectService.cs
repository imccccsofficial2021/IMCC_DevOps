using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Services
{
    public interface ISubjectService 
    {
        List<Subject> subject { get; set; }

        Task GetAllSubject();
        Task CreateNewSubjects(Subject subjectlist);
        Task<Subject> GetCourseNo(int id);
        Task DeleteSubject(int id);
        Task UpdateAllSubjects(Subject subjectlist, int id);
    }
}
