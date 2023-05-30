using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_commands_BlogId",
                table: "commands",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_commands_blogs_BlogId",
                table: "commands",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commands_blogs_BlogId",
                table: "commands");

            migrationBuilder.DropIndex(
                name: "IX_commands_BlogId",
                table: "commands");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "commands");
        }
    }
}
