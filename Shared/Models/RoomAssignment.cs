// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MudBlazorWASM.Shared.Models
{
    [Table("RoomAssignment")]
    [Index("InstructorId", Name = "IX_RoomAssignment_InstructorID", IsUnique = true)]
    public partial class RoomAssignment
    {
        [Key]
        public int Id { get; set; }
        [Column("InstructorID")]
        public int InstructorId { get; set; }
        [StringLength(50)]
        public string Location { get; set; }

        [ForeignKey("InstructorId")]
        [InverseProperty("RoomAssignment")]
        public virtual Instructor Instructor { get; set; }
    }
}