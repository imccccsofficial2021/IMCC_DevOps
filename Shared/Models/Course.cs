﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MudBlazorWASM.Shared.Models
{
    [Index("DepartmentId", Name = "IX_Courses_DepartmentID")]
    [Index("InstructorId", Name = "IX_Courses_InstructorID")]
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [Key]
        public int Id { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int? Credits { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column("InstructorID")]
        public int? InstructorId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Courses")]
        public virtual Department Department { get; set; }
        [ForeignKey("InstructorId")]
        [InverseProperty("Courses")]
        public virtual Instructor Instructor { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}