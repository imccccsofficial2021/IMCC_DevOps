using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{

    public partial class Subject
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? LecUnits { get; set; }
        public string? LabUnits { get; set; }
        public string? TotUnits { get; set; }
        public string? Department { get; set; }
        public string? PreRequisite { get; set; }

        public List<Egrade>? Egrades { get; set; }
    }
}
