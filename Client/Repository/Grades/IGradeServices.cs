using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Client.Repository.Grades
{
    public interface IGradeServices
    {
        HashSet<GradeSummary> GetListGrades { get; set; }
        Task GetGradeSummary();
        Task<GradeSummary> GetGradeItemAsync(string studentId);
        Task CreateGrade(GradeSummary grade);
        Task UpdateGrade(GradeSummary grade);
        Task DeleteGrade(GradeSummary grade);
    }
}
