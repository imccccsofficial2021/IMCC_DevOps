// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWASM.Shared.Models
{
    public partial class Admission
    {
        [Key]
        [Column("ENRID")]
        public int Enrid { get; set; }
        [Column("OFFERNO")]
        public int Offerno { get; set; }
        [Column("SUBJCODE")]
        [StringLength(50)]
        public string? Subjcode { get; set; }
        [Column("DEPTNO")]
        public int Deptno { get; set; }
        [Column("STUDNO")]
        public int Studno { get; set; }
        [Column("LASTNAME")]
        [StringLength(50)]
        public string? Lastname { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(50)]
        public string? Firstname { get; set; }
        [Column("MI")]
        [StringLength(50)]
        public string? Mi { get; set; }
        [Column("SEMCODE")]
        [StringLength(50)]
        public string? Semcode { get; set; }
        [Column("SYR")]
        [StringLength(50)]
        public string? Syr { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("CREATEDBY")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("DATECREATED")]
        [StringLength(50)]
        public DateTime DateCreated { get; set; }
    }
}