using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class propertyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titr",
                table: "tblDisciplines",
                newName: "Title");

            migrationBuilder.AlterColumn<float>(
                name: "KasreNomre",
                table: "tblDisciplines",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tblDisciplines",
                newName: "Titr");

            migrationBuilder.AlterColumn<int>(
                name: "KasreNomre",
                table: "tblDisciplines",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
