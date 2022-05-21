using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{

    public partial class SummaryGrades
    {
        public int Id { get; set; }
        public int? Deptno { get; set; }
        public int Offerno { get; set; }
        public string? Courseno { get; set; }
        public int Studno { get; set; }
        public string? Last { get; set; }
        public string? First { get; set; }
        public string? Mi { get; set; }
        public double? Term1 { get; set; }
        public double? Term2 { get; set; }
        public double? Term3 { get; set; }
        public double? Term4 { get; set; }
        public double? Average { get; set; }
        public string? Subjects { get; set; }
    }
}
