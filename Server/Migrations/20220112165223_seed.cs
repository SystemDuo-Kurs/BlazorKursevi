using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorKursevi.Server.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Osobe",
                columns: new[] { "Id", "Discriminator", "Ime", "Mejl", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { -6, "Polaznik", "Lkj", "lkj@l.l", "Lkj", "34235" },
                    { -5, "Polaznik", "Zxczxc", "zxc@bla.bla", "Zxczxc", "5363456346" },
                    { -4, "Polaznik", "Qweqwe", "q@q.q", "Asdasd", "0123135" },
                    { -3, "Predavac", "Asd", "asd@asd.asd", "Qwe", "65432" },
                    { -2, "Predavac", "Neko", "bla@bla.bla", "Nekic", "345345" },
                    { -1, "Predavac", "Pera", "p@p.p", "Peric", "12345" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Osobe",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
