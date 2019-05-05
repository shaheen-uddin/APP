using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class Dshe_info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DsheSL",
                table: "Trainees",
                maxLength: 3,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TraineeType",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DsheSL",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "TraineeType",
                table: "Trainees");
        }
    }
}
