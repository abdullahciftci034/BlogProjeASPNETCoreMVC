using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommandUserName",
                table: "commands",
                newName: "CommendUserName");

            migrationBuilder.RenameColumn(
                name: "CommandTitle",
                table: "commands",
                newName: "CommendTitle");

            migrationBuilder.RenameColumn(
                name: "CommandStatus",
                table: "commands",
                newName: "CommendStatus");

            migrationBuilder.RenameColumn(
                name: "CommandContent",
                table: "commands",
                newName: "CommendContent");

            migrationBuilder.RenameColumn(
                name: "CommandID",
                table: "commands",
                newName: "CommendID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommendUserName",
                table: "commands",
                newName: "CommandUserName");

            migrationBuilder.RenameColumn(
                name: "CommendTitle",
                table: "commands",
                newName: "CommandTitle");

            migrationBuilder.RenameColumn(
                name: "CommendStatus",
                table: "commands",
                newName: "CommandStatus");

            migrationBuilder.RenameColumn(
                name: "CommendContent",
                table: "commands",
                newName: "CommandContent");

            migrationBuilder.RenameColumn(
                name: "CommendID",
                table: "commands",
                newName: "CommandID");
        }
    }
}
