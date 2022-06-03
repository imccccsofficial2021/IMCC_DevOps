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
    public partial class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> entity)
        {
            entity.HasKey(e => e.Schedid);

            entity.Property(e => e.Schedid)
                .ValueGeneratedNever()
                .HasColumnName("SCHEDID");

            entity.Property(e => e.Days)
                .HasMaxLength(50)
                .HasColumnName("DAYS");

            entity.Property(e => e.Etime).HasColumnName("ETIME");

            entity.Property(e => e.Offerno).HasColumnName("OFFERNO");

            entity.Property(e => e.Session)
                .HasMaxLength(50)
                .HasColumnName("SESSION");

            entity.Property(e => e.Stime).HasColumnName("STIME");

            entity.Property(e => e.Subjcode)
                .HasMaxLength(50)
                .HasColumnName("SUBJCODE");

            entity.Property(e => e.Teachid).HasColumnName("TEACHID");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Schedule> entity);
    }
}
