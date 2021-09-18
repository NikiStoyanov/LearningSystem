using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningSystem.Migrations
{
    public partial class ExerciseUrl_column_on_lecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Lectures",
                newName: "VideoUrl");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseUrl",
                table: "Lectures",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseUrl",
                table: "Lectures");

            migrationBuilder.RenameColumn(
                name: "VideoUrl",
                table: "Lectures",
                newName: "Url");
        }
    }
}
