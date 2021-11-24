using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMSApp.ServiceLayer.Migrations
{
    public partial class CreateHrmsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeename = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    employeesalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    location = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
