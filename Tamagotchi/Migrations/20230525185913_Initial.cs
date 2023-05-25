using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tamagotchi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AmtFood = table.Column<int>(type: "int", nullable: false),
                    FoodPlus = table.Column<int>(type: "int", nullable: false),
                    FoodMin = table.Column<int>(type: "int", nullable: false),
                    FoodMax = table.Column<int>(type: "int", nullable: false),
                    Attention = table.Column<int>(type: "int", nullable: false),
                    AttnPlus = table.Column<int>(type: "int", nullable: false),
                    AttnMin = table.Column<int>(type: "int", nullable: false),
                    AttnMax = table.Column<int>(type: "int", nullable: false),
                    Rest = table.Column<int>(type: "int", nullable: false),
                    RestPlus = table.Column<int>(type: "int", nullable: false),
                    RestMin = table.Column<int>(type: "int", nullable: false),
                    RestMax = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
