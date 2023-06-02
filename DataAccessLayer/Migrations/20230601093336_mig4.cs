using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commands_blogs_BlogId",
                table: "commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_commands",
                table: "commands");

            migrationBuilder.RenameTable(
                name: "commands",
                newName: "commends");

            migrationBuilder.RenameIndex(
                name: "IX_commands_BlogId",
                table: "commends",
                newName: "IX_commends_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_commends",
                table: "commends",
                column: "CommendID");

            migrationBuilder.AddForeignKey(
                name: "FK_commends_blogs_BlogId",
                table: "commends",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commends_blogs_BlogId",
                table: "commends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_commends",
                table: "commends");

            migrationBuilder.RenameTable(
                name: "commends",
                newName: "commands");

            migrationBuilder.RenameIndex(
                name: "IX_commends_BlogId",
                table: "commands",
                newName: "IX_commands_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_commands",
                table: "commands",
                column: "CommendID");

            migrationBuilder.AddForeignKey(
                name: "FK_commands_blogs_BlogId",
                table: "commands",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
