using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class Participant_ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParticipantID",
                table: "Trainees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticipantID",
                table: "Trainees");
        }
    }
}
