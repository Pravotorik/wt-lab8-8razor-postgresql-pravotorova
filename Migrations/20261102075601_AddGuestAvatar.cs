using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wt_lab8_8razor_postgresql_pravotorova.Migrations
{
    /// <inheritdoc />
    public partial class AddGuestAvatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarUrl",
                value: "https://i.pravatar.cc/150?img=47");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatarUrl",
                value: "https://i.pravatar.cc/150?img=12");

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "AvatarUrl", "Country", "Email", "FullName", "Phone" },
                values: new object[] { 3, "https://i.pravatar.cc/150?img=32", "Польша", "maria@mail.com", "Мария Ковалёва", "+375 29 777-88-99" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvatarUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatarUrl",
                value: "");
        }
    }
}
