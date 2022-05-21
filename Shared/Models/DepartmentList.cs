using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    public class DepartmentList
    {
        [Key]
        public int ID { get; set; }
        public int DEPTNO { get; set; }
        public string? ABBREV { get; set; }
        public string? DESCRIPTION { get; set; }
    }
}