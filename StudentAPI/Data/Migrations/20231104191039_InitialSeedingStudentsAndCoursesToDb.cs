using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedingStudentsAndCoursesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaughtBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatricNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdmittedDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "TaughtBy" },
                values: new object[,]
                {
                    { 1, "MATH101", "Mathematics", "Professor Smith" },
                    { 2, "HIST101", "History", "Professor Johnson" },
                    { 3, "BIO101", "Biology", "Professor Wilson" },
                    { 4, "CHEM101", "Chemistry", "Professor Brown" },
                    { 5, "CSCI101", "Computer Science", "Professor Davis" },
                    { 6, "ENGL101", "English Literature", "Professor White" },
                    { 7, "PHYS101", "Physics", "Professor Anderson" },
                    { 8, "PSYCH101", "Psychology", "Professor Martinez" },
                    { 9, "ECON101", "Economics", "Professor Robinson" },
                    { 10, "ARTH101", "Art History", "Professor Garcia" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AdmittedDay", "DateOfBirth", "Department", "FirstName", "LastName", "MatricNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "John", "Doe", "M001" },
                    { 2, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biology", "Alice", "Smith", "M002" },
                    { 3, new DateTime(2018, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mathematics", "Bob", "Johnson", "M003" },
                    { 4, new DateTime(2017, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Physics", "Sarah", "Williams", "M004" },
                    { 5, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemistry", "Mike", "Brown", "M005" },
                    { 6, new DateTime(2015, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "History", "Linda", "Davis", "M006" },
                    { 7, new DateTime(2018, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Economics", "Mark", "Martinez", "M007" },
                    { 8, new DateTime(2014, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychology", "Emily", "Taylor", "M008" },
                    { 9, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", "James", "Garcia", "M009" },
                    { 10, new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sociology", "Olivia", "Hernandez", "M010" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
