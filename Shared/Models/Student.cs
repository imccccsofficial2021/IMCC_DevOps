// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWASM.Shared.Models
{
    public partial class Student
    {
        [Column("STUDCOUNT")]
        public int Studcount { get; set; }
        [Key]
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
        [Column("DEPTNO")]
        public int Deptno { get; set; }
        [Column("GENDER")]
        [StringLength(50)]
        public string? Gender { get; set; }
        [Column("RELIGION")]
        [StringLength(50)]
        public string? Religion { get; set; }
        [Column("SCHOLAR")]
        [StringLength(50)]
        public string? Scholar { get; set; }
        [Column("SCHCODE")]
        public int Schcode { get; set; }
        [Column("AWARDNO")]
        public int Awardno { get; set; }
        [Column("SLOTNO")]
        public int Slotno { get; set; }
        [Column("CLAIMNO")]
        public int Claimno { get; set; }
        [Column("CREDITNO")]
        public int Creditno { get; set; }
        [Column("GRANTNO")]
        public int Grantno { get; set; }
        [Column("SCHGRANT")]
        [StringLength(50)]
        public string? Schgrant { get; set; }
        [Column("SCHAPP")]
        [StringLength(50)]
        public string? Schapp { get; set; }
        [Column("REGION")]
        [StringLength(50)]
        public string? Region { get; set; }
        [Column("SCHACCT")]
        [StringLength(50)]
        public string? Schacct { get; set; }
        [Column("SCHADD", TypeName = "ntext")]
        public string? Schadd { get; set; }
        [Column("SCHVET")]
        [StringLength(50)]
        public string? Schvet { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("PTAG")]
        [StringLength(50)]
        public string? Ptag { get; set; }
    }
}