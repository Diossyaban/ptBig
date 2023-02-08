using Microsoft.EntityFrameworkCore.Migrations;

namespace PTBIG.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnakKelas11s",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kelas = table.Column<int>(type: "int", nullable: false),
                    Umur = table.Column<int>(type: "int", nullable: false),
                    Tinggi = table.Column<int>(type: "int", nullable: false),
                    Berat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnakKelas11s", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnakKelas11s");
        }
    }
}
