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
    public partial class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasKey(e => e.Deptno);

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("DEPTNO");

            entity.Property(e => e.Abbreviations)
                .HasMaxLength(50)
                .HasColumnName("ABBREVIATIONS");

            entity.Property(e => e.Deptcount)
                .ValueGeneratedOnAdd()
                .HasColumnName("DEPTCOUNT");

            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Department> entity);
    }
}