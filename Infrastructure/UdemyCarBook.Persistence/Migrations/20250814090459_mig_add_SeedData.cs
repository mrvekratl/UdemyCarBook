using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "Name" },
                values: new object[,]
                {
                    { 1, "Volkswagen" },
                    { 2, "BMW" },
                    { 3, "Mercedes" },
                    { 4, "Renault" },
                    { 5, "Toyota" },
                    { 6, "Hyundai" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul - Sabiha Gökçen Havalimanı" },
                    { 2, "İstanbul - İstanbul Havalimanı" },
                    { 3, "Ankara - Esenboğa Havalimanı" },
                    { 4, "İzmir - Adnan Menderes Havalimanı" },
                    { 5, "Antalya - Antalya Havalimanı" },
                    { 6, "Bursa - Yenişehir Havalimanı" },
                    { 7, "Adana - Şakirpaşa Havalimanı" },
                    { 8, "Trabzon - Trabzon Havalimanı" },
                    { 9, "Gaziantep - Oğuzeli Havalimanı" },
                    { 10, "Dalaman - Dalaman Havalimanı" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BigImageUrl", "BrandID", "CoverImageUrl", "Fuel", "Km", "Luggage", "Model", "Seat", "Transmission" },
                values: new object[,]
                {
                    { 1, null, 1, "/images/polo.jpg", "Benzin", 35000, (byte)2, "Polo", (byte)5, "Manuel" },
                    { 2, null, 1, "/images/golf.jpg", "Dizel", 42000, (byte)3, "Golf", (byte)5, "Otomatik" },
                    { 3, null, 2, "/images/bmw3.jpg", "Benzin", 28000, (byte)4, "3 Serisi", (byte)5, "Otomatik" },
                    { 4, null, 2, "/images/bmw5.jpg", "Dizel", 50000, (byte)4, "5 Serisi", (byte)5, "Otomatik" },
                    { 5, null, 3, "/images/c200.jpg", "Benzin", 31000, (byte)4, "C200", (byte)5, "Otomatik" },
                    { 6, null, 3, "/images/e200.jpg", "Dizel", 45000, (byte)4, "E200", (byte)5, "Otomatik" },
                    { 7, null, 4, "/images/clio.jpg", "Benzin", 29000, (byte)2, "Clio", (byte)5, "Manuel" },
                    { 8, null, 4, "/images/megane.jpg", "Dizel", 37000, (byte)3, "Megane", (byte)5, "Otomatik" },
                    { 9, null, 5, "/images/corolla.jpg", "Benzin", 33000, (byte)3, "Corolla", (byte)5, "Otomatik" },
                    { 10, null, 5, "/images/yaris.jpg", "Hibrit", 25000, (byte)2, "Yaris", (byte)5, "Manuel" },
                    { 11, null, 6, "/images/i20.jpg", "Benzin", 21000, (byte)2, "i20", (byte)5, "Manuel" },
                    { 12, null, 6, "/images/i30.jpg", "Dizel", 34000, (byte)3, "i30", (byte)5, "Otomatik" },
                    { 13, null, 1, "/images/passat.jpg", "Dizel", 48000, (byte)4, "Passat", (byte)5, "Otomatik" },
                    { 14, null, 2, "/images/x1.jpg", "Benzin", 39000, (byte)4, "X1", (byte)5, "Otomatik" },
                    { 15, null, 3, "/images/gla200.jpg", "Benzin", 27000, (byte)3, "GLA 200", (byte)5, "Otomatik" },
                    { 16, null, 4, "/images/symbol.jpg", "Benzin", 45000, (byte)2, "Symbol", (byte)5, "Manuel" },
                    { 17, null, 5, "/images/camry.jpg", "Hibrit", 37000, (byte)4, "Camry", (byte)5, "Otomatik" },
                    { 18, null, 6, "/images/tucson.jpg", "Dizel", 32000, (byte)4, "Tucson", (byte)5, "Otomatik" },
                    { 19, null, 1, "/images/troc.jpg", "Benzin", 22000, (byte)3, "T-Roc", (byte)5, "Otomatik" },
                    { 20, null, 2, "/images/x5.jpg", "Dizel", 55000, (byte)5, "X5", (byte)5, "Otomatik" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandID",
                keyValue: 6);
        }
    }
}
