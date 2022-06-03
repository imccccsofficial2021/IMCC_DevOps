﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWASM.Shared.Models
{
    public partial class Schedule
    {
        [Key]
        [Column("SCHEDID")]
        public int Schedid { get; set; }
        [Column("STIME")]
        public TimeSpan? Stime { get; set; }
        [Column("ETIME")]
        public TimeSpan? Etime { get; set; }
        [Column("TYPE")]
        [StringLength(50)]
        public string? Type { get; set; }
        [Column("DAYS")]
        [StringLength(50)]
        public string? Days { get; set; }
        [Column("TEACHID")]
        public int? Teachid { get; set; }
        [Column("SUBJCODE")]
        [StringLength(50)]
        public string? Subjcode { get; set; }
        [Column("OFFERNO")]
        public int? Offerno { get; set; }
        [Column("SESSION")]
        [StringLength(50)]
        public string? Session { get; set; }
    }
}