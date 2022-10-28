using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProAuto.Migrations
{
    public partial class AddColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Associados",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Associados");
        }
    }
}
