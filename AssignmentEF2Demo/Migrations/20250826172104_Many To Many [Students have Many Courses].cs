using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentEF2Demo.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyStudentshaveManyCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false),
                    SId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.CId, x.SId });
                    table.ForeignKey(
                        name: "FK_Stud_Course_Courses_CId",
                        column: x => x.CId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Course_Students_SId",
                        column: x => x.SId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_SId",
                table: "Stud_Course",
                column: "SId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Course");
        }
    }
}
