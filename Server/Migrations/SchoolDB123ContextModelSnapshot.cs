﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudBlazorWASM.Server.Data;

#nullable disable

namespace MudBlazorWASM.Server.Migrations
{
    [DbContext(typeof(SchoolDB123Context))]
    partial class SchoolDB123ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.DepartmentList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ABBREV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DEPTNO")
                        .HasColumnType("int");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.EGradeDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("EGradeDetails", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.Enrollment", b =>
                {
                    b.Property<int>("ItemNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemNo"), 1L, 1);

                    b.Property<string>("CourseDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemNo");

                    b.ToTable("Enrollment", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.StudentList", b =>
                {
                    b.Property<int>("STUDNO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("STUDNO"), 1L, 1);

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STUDNO");

                    b.ToTable("StudentList", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.SubjectList", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("COURSEDESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COURSENO")
                        .HasColumnType("int");

                    b.Property<int>("CREDITS")
                        .HasColumnType("int");

                    b.Property<string>("Enrollments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SubjectList", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.SummaryGrades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Average")
                        .HasColumnType("float");

                    b.Property<string>("Courseno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deptno")
                        .HasColumnType("int");

                    b.Property<string>("First")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Offerno")
                        .HasColumnType("int");

                    b.Property<int>("Studno")
                        .HasColumnType("int");

                    b.Property<string>("Subjects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Term1")
                        .HasColumnType("float");

                    b.Property<double?>("Term2")
                        .HasColumnType("float");

                    b.Property<double?>("Term3")
                        .HasColumnType("float");

                    b.Property<double?>("Term4")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SummaryGrades", (string)null);
                });

            modelBuilder.Entity("MudBlazorWASM.Shared.Models.TeachingStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("TeachingStaff", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
