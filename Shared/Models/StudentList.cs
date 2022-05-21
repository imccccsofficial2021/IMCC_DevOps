using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    public class StudentList
    {
        public int ID { get; set; }
        [Key]
        public int STUDNO { get; set; }
        public string? LASTNAME { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? MI { get; set; }
        //public DateTime EnrolmentDate { get; set; }

       // public ICollection<Enrollment> Enrollments { get; set; }
    }
}