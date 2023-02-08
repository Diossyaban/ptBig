using Microsoft.EntityFrameworkCore.Migrations;

namespace PTBIG.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Berat",
                table: "AnakKelas11s",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Berat",
                table: "AnakKelas11s");
        }
    }
}
