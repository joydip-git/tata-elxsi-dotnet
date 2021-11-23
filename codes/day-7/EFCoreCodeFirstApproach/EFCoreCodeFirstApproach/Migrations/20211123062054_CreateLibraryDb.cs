using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstApproach.Migrations
{
    public partial class CreateLibraryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "memberrecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    membername = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberrecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bookrecords",
                columns: table => new
                {
                    bookid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    memberid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookrecords", x => x.bookid);
                    table.ForeignKey(
                        name: "FK_bookrecords_memberrecords_memberid",
                        column: x => x.memberid,
                        principalTable: "memberrecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookrecords_memberid",
                table: "bookrecords",
                column: "memberid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookrecords");

            migrationBuilder.DropTable(
                name: "memberrecords");
        }
    }
}
