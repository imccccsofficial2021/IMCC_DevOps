using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBlazorWASM.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPTNO = table.Column<int>(type: "int", nullable: false),
                    ABBREV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EGradeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGradeDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    ItemNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfferNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.ItemNo);
                });

            migrationBuilder.CreateTable(
                name: "StudentList",
                columns: table => new
                {
                    STUDNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentList", x => x.STUDNO);
                });

            migrationBuilder.CreateTable(
                name: "SubjectList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    COURSENO = table.Column<int>(type: "int", nullable: false),
                    COURSEDESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREDITS = table.Column<int>(type: "int", nullable: false),
                    Enrollments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SummaryGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deptno = table.Column<int>(type: "int", nullable: true),
                    Offerno = table.Column<int>(type: "int", nullable: false),
                    Courseno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Studno = table.Column<int>(type: "int", nullable: false),
                    Last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Term1 = table.Column<double>(type: "float", nullable: true),
                    Term2 = table.Column<double>(type: "float", nullable: true),
                    Term3 = table.Column<double>(type: "float", nullable: true),
                    Term4 = table.Column<double>(type: "float", nullable: true),
                    Average = table.Column<double>(type: "float", nullable: true),
                    Subjects = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummaryGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeachingStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingStaff", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EGradeDetails");

            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "StudentList");

            migrationBuilder.DropTable(
                name: "SubjectList");

            migrationBuilder.DropTable(
                name: "SummaryGrades");

            migrationBuilder.DropTable(
                name: "TeachingStaff");
        }
    }
}
