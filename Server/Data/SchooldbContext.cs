// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MudBlazorWASM.Server;
using MudBlazorWASM.Server.Data.Configurations;
using System;
using System.Collections.Generic;
#nullable enable

namespace MudBlazorWASM.Server.Data
{
    public partial class SchooldbContext : DbContext
    {
        public SchooldbContext()
        {
        }

        public SchooldbContext(DbContextOptions<SchooldbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<OfferedSubject> OfferedSubjects { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SubmittedGrade> SubmittedGrades { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.ClassroomConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OfferedSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.StudentConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SubmittedGradeConfiguration());

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingGeneratedFunctions(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
