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
    public partial class AdmissionConfiguration : IEntityTypeConfiguration<Admission>
    {
        public void Configure(EntityTypeBuilder<Admission> entity)
        {
            entity.HasKey(e => e.Enrid);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Admission> entity);
    }
}