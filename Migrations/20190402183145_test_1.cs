using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class test_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NameOfCadre",
                table: "Trainees",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NameOfCadre",
                table: "Trainees",
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 150);
        }
    }
}
