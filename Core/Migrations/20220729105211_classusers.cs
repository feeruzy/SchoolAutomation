using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class classusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudents_tblUsers_UserId",
                table: "tblStudents");

            migrationBuilder.DropIndex(
                name: "IX_tblStudents_UserId",
                table: "tblStudents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tblStudents");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_Fk_userId",
                table: "tblStudents",
                column: "Fk_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudents_tblUsers_Fk_userId",
                table: "tblStudents",
                column: "Fk_userId",
                principalTable: "tblUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudents_tblUsers_Fk_userId",
                table: "tblStudents");

            migrationBuilder.DropIndex(
                name: "IX_tblStudents_Fk_userId",
                table: "tblStudents");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
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
    }
}
