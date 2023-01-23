using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iulia_Borca_Proiect.Migrations
{
    public partial class GreenhouseCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GreenhouseID",
                table: "Flower",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Greenhouse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GreenhouseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Greenhouse", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flower_GreenhouseID",
                table: "Flower",
                column: "GreenhouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_Greenhouse_GreenhouseID",
                table: "Flower",
                column: "GreenhouseID",
                principalTable: "Greenhouse",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flower_Greenhouse_GreenhouseID",
                table: "Flower");

            migrationBuilder.DropTable(
                name: "Greenhouse");

            migrationBuilder.DropIndex(
                name: "IX_Flower_GreenhouseID",
                table: "Flower");

            migrationBuilder.DropColumn(
                name: "GreenhouseID",
                table: "Flower");
        }
    }
}
