using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class addModelStudentPhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Students");
        }
    }
}
