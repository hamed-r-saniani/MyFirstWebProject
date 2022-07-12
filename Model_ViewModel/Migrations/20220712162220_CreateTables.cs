using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model_ViewModel.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    DegreeID = table.Column<int>(nullable: false),
                    DegreeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Degree = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IAccept = table.Column<bool>(nullable: false),
                    Website = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<long>(nullable: false),
                    ProductDesc = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true),
                    ProductShortDesc = table.Column<string>(nullable: true),
                    ProductCategoryID = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    CategoryGuid = table.Column<Guid>(nullable: true),
                    PersonGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryGuid",
                        column: x => x.CategoryGuid,
                        principalTable: "Category",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Person_PersonGuid",
                        column: x => x.PersonGuid,
                        principalTable: "Person",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryGuid",
                table: "Product",
                column: "CategoryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PersonGuid",
                table: "Product",
                column: "PersonGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
