using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Shared.Models;
//using MudBlazorWASM.Shared.Models.AuthenticationUser;

namespace MudBlazorWASM.Server.Data
{
    public partial class SchoolDB123Context : DbContext
    {

        public SchoolDB123Context(DbContextOptions<SchoolDB123Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AppRole> AppRoles { get; set; } = null!;
        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
        public virtual DbSet<DepartmentList> DepartmentLists { get; set; } = null!;
        public virtual DbSet<EGradeDetails> Egrades { get; set; } = null!;
        public virtual DbSet<StudentList> StudentLists { get; set; } = null!;
        public virtual DbSet<SubjectList> SubjectLists { get; set; } = null!;
        public virtual DbSet<SummaryGrades> SummaryGradesList { get; set; } = null!;
        public virtual DbSet<TeachingStaff> TeachingStaffs { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        //public HashSet<StudentList> Students123 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SchoolDB123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubjectList>().ToTable("SubjectList");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<StudentList>().ToTable("StudentList");
            modelBuilder.Entity<DepartmentList>().ToTable("Department");
            modelBuilder.Entity<TeachingStaff>().ToTable("TeachingStaff");
            modelBuilder.Entity<SummaryGrades>().ToTable("SummaryGrades");
            modelBuilder.Entity<EGradeDetails>().ToTable("EGradeDetails");


        }

    }
}