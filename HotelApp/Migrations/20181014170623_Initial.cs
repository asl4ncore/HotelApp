using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IIN = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Patronymic = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelCountries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    HotelCategoryId = table.Column<int>(nullable: false),
                    HotelTypeId = table.Column<int>(nullable: false),
                    HotelCountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_HotelCategories_HotelCategoryId",
                        column: x => x.HotelCategoryId,
                        principalTable: "HotelCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_HotelCountries_HotelCountryId",
                        column: x => x.HotelCountryId,
                        principalTable: "HotelCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_HotelTypes_HotelTypeId",
                        column: x => x.HotelTypeId,
                        principalTable: "HotelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassifactionId = table.Column<int>(nullable: false),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryNumbers_Classifactions_ClassifactionId",
                        column: x => x.ClassifactionId,
                        principalTable: "Classifactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryNumbers_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    CategoryNumberId = table.Column<int>(nullable: false),
                    Parameters = table.Column<string>(nullable: true),
                    PayType = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    DateArrival = table.Column<DateTime>(nullable: false),
                    DateDeparture = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CategoryNumbers_CategoryNumberId",
                        column: x => x.CategoryNumberId,
                        principalTable: "CategoryNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryNumbers_ClassifactionId",
                table: "CategoryNumbers",
                column: "ClassifactionId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryNumbers_HotelId",
                table: "CategoryNumbers",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotelCategoryId",
                table: "Hotels",
                column: "HotelCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotelCountryId",
                table: "Hotels",
                column: "HotelCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotelTypeId",
                table: "Hotels",
                column: "HotelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CategoryNumberId",
                table: "Orders",
                column: "CategoryNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CategoryNumbers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Classifactions");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "HotelCategories");

            migrationBuilder.DropTable(
                name: "HotelCountries");

            migrationBuilder.DropTable(
                name: "HotelTypes");
        }
    }
}
