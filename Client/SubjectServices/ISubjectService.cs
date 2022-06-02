﻿namespace MudBlazorWASM.Client.SubjectServices
{
    public interface ISubjectService
    {
        List<Subject> subject { get; set; }

        Task GetAllSubject();
        Task CreateNewSubjects(Subject subjectlist);
        Task<Subject> GetCourseNo(int courseno);
        Task DeleteSubject(int id);
        Task UpdateAllSubjects(Subject subjectlist);
    }
}
