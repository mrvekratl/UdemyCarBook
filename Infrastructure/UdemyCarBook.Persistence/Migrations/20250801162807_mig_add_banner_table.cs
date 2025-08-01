using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_banner_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPricing_Cars_CarID",
                table: "CarPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricing_Pricings_PricingID",
                table: "CarPricing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPricing",
                table: "CarPricing");

            migrationBuilder.RenameTable(
                name: "CarPricing",
                newName: "CarPricings");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricing_PricingID",
                table: "CarPricings",
                newName: "IX_CarPricings_PricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricing_CarID",
                table: "CarPricings",
                newName: "IX_CarPricings_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPricings",
                table: "CarPricings",
                column: "CarPricingID");

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    BannerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.BannerID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings",
                column: "PricingID",
                principalTable: "Pricings",
                principalColumn: "PricingID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPricings",
                table: "CarPricings");

            migrationBuilder.RenameTable(
                name: "CarPricings",
                newName: "CarPricing");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_PricingID",
                table: "CarPricing",
                newName: "IX_CarPricing_PricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricing",
                newName: "IX_CarPricing_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPricing",
                table: "CarPricing",
                column: "CarPricingID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricing_Cars_CarID",
                table: "CarPricing",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricing_Pricings_PricingID",
                table: "CarPricing",
                column: "PricingID",
                principalTable: "Pricings",
                principalColumn: "PricingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
