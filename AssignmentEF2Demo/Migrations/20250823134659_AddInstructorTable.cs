using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentEF2Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddInstructorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HourRateBouns = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    Dept_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.CheckConstraint("HourRateBounsIs0OrMore", "HourRateBouns >= 0");
                    table.CheckConstraint("SalaryIsNot0OrLess", "Salary > 0");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
