using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentInfoAPI.Migrations
{
    public partial class StudentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    S_LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    S_MiddleName = table.Column<string>(type: "varchar(50)", nullable: true),
                    StudentLevel = table.Column<int>(type: "int", nullable: false),
                    StudentContacts = table.Column<string>(type: "varchar(50)", nullable: true),
                    StudentEmail = table.Column<string>(type: "varchar(50)", nullable: true),
                    TDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UDT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
