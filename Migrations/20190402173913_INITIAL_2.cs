using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class INITIAL_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Venue",
                table: "Trainees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Venue",
                table: "Trainees",
                nullable: true);
        }
    }
}
