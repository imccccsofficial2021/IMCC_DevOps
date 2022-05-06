using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWASM.Shared.Models
{
    public class SubjectList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int COURSENO { get; set; }
        public string? COURSEDESC { get; set; }
        public int CREDITS { get; set; }

        public string Enrollments { get; set; }
    }
}