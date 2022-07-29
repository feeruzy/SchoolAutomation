using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class classuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FK_StudentNumber",
                table: "tblStudents",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "Fk_userId",
                table: "tblStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_UserId",
                table: "tblStudents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudents_tblUsers_UserId",
                table: "tblStudents",
                column: "UserId",
                principalTable: "tblUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudents_tblUsers_UserId",
                table: "tblStudents");

            migrationBuilder.DropIndex(
                name: "IX_tblStudents_UserId",
                table: "tblStudents");

            migrationBuilder.DropColumn(
                name: "Fk_userId",
                table: "tblStudents");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tblStudents",
                newName: "FK_StudentNumber");
        }
    }
}
