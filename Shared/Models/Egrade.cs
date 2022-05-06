using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    [Serializable]
    public partial class Egrade
    {
        [Key]
        public int Id { get; set; }
        public string? StudentNo { get; set; }
        public string? StudentName { get; set; }
        public string? Description { get; set; }
        public string? OfferNo { get; set; }
        public string? TotUnits { get; set; }
        public string? Day { get; set; }
        public string? Time { get; set; }
        public string? Semester { get; set; }
        public string? Syear { get; set; }
        public int DepartmentsId { get; set; }
        public List<Subject>? Subjects { get; set; }
        public int SubjectCode { get; set; }
    }
}
