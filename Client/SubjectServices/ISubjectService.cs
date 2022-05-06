namespace MudBlazorWASM.Client.SubjectServices
{
    public interface ISubjectService
    {
        List<SubjectList> subject { get; set; }

        Task GetAllSubject();
        Task CreateNewSubjects(SubjectList subjectlist);
        Task<SubjectList> GetCourseNo(int courseno);
        Task DeleteSubject(int id);
        Task UpdateAllSubjects(SubjectList subjectlist);
    }
}
