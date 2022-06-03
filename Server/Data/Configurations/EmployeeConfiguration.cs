﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
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
    public partial class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("ADDRESS1");

            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS2");

            entity.Property(e => e.Completename)
                .HasMaxLength(50)
                .HasColumnName("COMPLETENAME");

            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("DEPARTMENT");

            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.Idno).HasColumnName("IDNO");

            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");

            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("POSITION");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employee> entity);
    }
}
