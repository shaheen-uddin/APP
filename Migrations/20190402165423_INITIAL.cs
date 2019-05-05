using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProject.Migrations
{
    public partial class INITIAL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Course_Name = table.Column<int>(nullable: false),
                    BatchNo = table.Column<int>(nullable: false),
                    OpeningDate = table.Column<DateTime>(nullable: false),
                    ClosingDate = table.Column<DateTime>(nullable: false),
                    LastNaemCourseAttendeded = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    FatherName = table.Column<string>(maxLength: 100, nullable: true),
                    MotherName = table.Column<string>(maxLength: 100, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    BloodGroup = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<int>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    CellNo = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    NID = table.Column<string>(nullable: false),
                    PermanentAddress = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(maxLength: 100, nullable: false),
                    IndexNo = table.Column<string>(maxLength: 20, nullable: false),
                    NameOfCadre = table.Column<int>(nullable: true),
                    BCSBatchNo = table.Column<int>(nullable: true),
                    WorkplaceAddress = table.Column<string>(nullable: false),
                    EiinNo = table.Column<int>(nullable: true),
                    AcademicQualification = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(maxLength: 100, nullable: false),
                    EmmergencyContactName = table.Column<string>(nullable: false),
                    EmmergencyContactCellNo = table.Column<string>(maxLength: 11, nullable: false),
                    ProfileImagePath = table.Column<string>(nullable: true),
                    SignatureImgPath = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trainees");
        }
    }
}
