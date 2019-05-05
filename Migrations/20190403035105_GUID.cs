using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class GUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NameOfCadre",
                table: "Trainees",
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 150);

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Trainees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "NameOfCadre",
                table: "Trainees",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
