using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRegistration.Migrations
{
    public partial class ChangedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FacultyName",
                table: "Faculties",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DeptName",
                table: "Departments",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Faculties",
                newName: "FacultyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "DeptName");
        }
    }
}
