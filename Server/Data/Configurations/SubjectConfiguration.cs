// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MudBlazorWASM.Server;
using MudBlazorWASM.Server.Data;
using System;
using System.Collections.Generic;

#nullable disable

namespace MudBlazorWASM.Server.Data.Configurations
{
    public partial class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .HasColumnName("CATEGORY");

            entity.Property(e => e.Coursecode)
                .HasMaxLength(50)
                .HasColumnName("COURSECODE");

            entity.Property(e => e.Coursedesc)
                .HasMaxLength(100)
                .HasColumnName("COURSEDESC");

            entity.Property(e => e.Courseno)
                .HasMaxLength(50)
                .HasColumnName("COURSENO");

            entity.Property(e => e.Deptno)
                .HasMaxLength(50)
                .HasColumnName("DEPTNO");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Lab).HasColumnName("LAB");

            entity.Property(e => e.Lec).HasColumnName("LEC");

            entity.Property(e => e.Prereq)
                .HasMaxLength(50)
                .HasColumnName("PREREQ");

            entity.Property(e => e.Semcode)
                .HasMaxLength(50)
                .HasColumnName("SEMCODE");

            entity.Property(e => e.Semester)
                .HasMaxLength(50)
                .HasColumnName("SEMESTER");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.Tyype)
                .HasMaxLength(50)
                .HasColumnName("TYYPE");

            entity.Property(e => e.Units).HasColumnName("UNITS");

            entity.Property(e => e.Yrlevel)
                .HasMaxLength(50)
                .HasColumnName("YRLEVEL");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Subject> entity);
    }
}
