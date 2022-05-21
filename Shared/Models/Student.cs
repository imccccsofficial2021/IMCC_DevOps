using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    [Serializable]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string? StudentNo { get; set; }
        public string? StudentName { get; set; }
        public string? ContactNo { get; set; }
        public string? Birthdate { get; set; }
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Religion { get; set; }
    }
}
