using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Nowe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubCategory",
                table: "ContactDetails",
                type: "nvarchar(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(32)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactDetails",
                type: "nvarchar(9)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(9)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ContactDetails",
                type: "nvarchar(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(32)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ContactDetails",
                type: "nvarchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ContactDetails",
                type: "nvarchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactDetails",
                type: "nvarchar(70)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(70)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "ContactDetails",
                type: "nvarchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(16)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubCategory",
                table: "ContactDetails",
                type: "nchar(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactDetails",
                type: "nchar(9)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ContactDetails",
                type: "nchar(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ContactDetails",
                type: "nchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ContactDetails",
                type: "nchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactDetails",
                type: "nchar(70)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "ContactDetails",
                type: "nchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)");
        }
    }
}
