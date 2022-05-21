using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorWASM.Shared.Models
{
    public class Enrollment
    {
        [Key]
        public int ItemNo { get; set; }
        public string? RegNo { get; set; } = null;
        public string? StudNo { get; set; } = null;
        public string? LastName { get; set; } = null;
        public string? FirstName { get; set; } = null;
        public string? MiddleName { get; set; } = null;
        public string? Department { get; set; } = null;
        public string? OfferNo { get; set; } = null;
        public string? CourseNo { get; set; } = null;
        public string? CourseDesc { get; set; } = null;
        public string? TeacherId { get; set; } = null;
        public string? SectionId { get; set; } = null;
        public string? TimeId { get; set; } = null;
        public string? RoomId { get; set; } = null;
        public string? Days { get; set; } = null;
        public string? Units { get; set; } = null;
        public string? CreatedBy { get; set; } = null;
        public string? CreatedOn { get; set; } = null;


    }
}
