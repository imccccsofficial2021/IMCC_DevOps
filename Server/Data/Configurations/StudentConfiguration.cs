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
    public partial class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.HasKey(e => e.Studno);

            entity.Property(e => e.Studno)
                .ValueGeneratedNever()
                .HasColumnName("STUDNO");

            entity.Property(e => e.Awardno).HasColumnName("AWARDNO");

            entity.Property(e => e.Claimno).HasColumnName("CLAIMNO");

            entity.Property(e => e.Creditno).HasColumnName("CREDITNO");

            entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("GENDER");

            entity.Property(e => e.Grantno).HasColumnName("GRANTNO");

            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");

            entity.Property(e => e.Ptag)
                .HasMaxLength(50)
                .HasColumnName("PTAG");

            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("REGION");

            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .HasColumnName("RELIGION");

            entity.Property(e => e.Schacct)
                .HasMaxLength(50)
                .HasColumnName("SCHACCT");

            entity.Property(e => e.Schadd)
                .HasColumnType("ntext")
                .HasColumnName("SCHADD");

            entity.Property(e => e.Schapp)
                .HasMaxLength(50)
                .HasColumnName("SCHAPP");

            entity.Property(e => e.Schcode).HasColumnName("SCHCODE");

            entity.Property(e => e.Schgrant)
                .HasMaxLength(50)
                .HasColumnName("SCHGRANT");

            entity.Property(e => e.Scholar)
                .HasMaxLength(50)
                .HasColumnName("SCHOLAR");

            entity.Property(e => e.Schvet)
                .HasMaxLength(50)
                .HasColumnName("SCHVET");

            entity.Property(e => e.Slotno).HasColumnName("SLOTNO");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.Studcount)
                .ValueGeneratedOnAdd()
                .HasColumnName("STUDCOUNT");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Student> entity);
    }
}
