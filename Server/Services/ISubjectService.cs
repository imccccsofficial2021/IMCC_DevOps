using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Services
{
    public interface ISubjectService 
    {
        List<SubjectList> subject { get; set; }

        Task GetAllSubject();
        Task CreateNewSubjects(SubjectList subjectlist);
        Task<SubjectList> GetCourseNo(int id);
        Task DeleteSubject(int id);
        Task UpdateAllSubjects(SubjectList subjectlist, int id);
    }
}
