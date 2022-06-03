namespace MudBlazorWASM.Client.Repository.Grades
{
    public interface IGradeServices
    {
        HashSet<SubmittedGrade> GetListGrades { get; set; }
        Task GetGradeSummary();
        Task<SubmittedGrade> GetGradeItemAsync(string studentId);
        Task CreateGrade(SubmittedGrade grade);
        Task UpdateGrade(SubmittedGrade grade);
        Task DeleteGrade(SubmittedGrade grade);
    }
}
