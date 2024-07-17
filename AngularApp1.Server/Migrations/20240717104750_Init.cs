using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nchar(40)", nullable: false),
                    LastName = table.Column<string>(type: "nchar(40)", nullable: false),
                    Email = table.Column<string>(type: "nchar(70)", nullable: false),
                    Password = table.Column<string>(type: "nchar(32)", nullable: false),
                    Category = table.Column<string>(type: "nchar(16)", nullable: false),
                    SubCategory = table.Column<string>(type: "nchar(32)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nchar(9)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.ContactID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");
        }
    }
}
