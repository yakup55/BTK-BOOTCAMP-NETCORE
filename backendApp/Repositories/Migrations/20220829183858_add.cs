using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 10m),
                    BookAtCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookAuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => x.BookAuthorId);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookNumberOfPage = table.Column<int>(type: "int", nullable: false),
                    BookISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPublisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetailId);
                    table.ForeignKey(
                        name: "FK_BookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId");
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorFirstName", "AuthorLastName" },
                values: new object[,]
                {
                    { 1, "Yakup", "Yıldırım" },
                    { 2, "Murat", "Çalış" },
                    { 3, "Ethem", "Koç" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookPrice", "BookSummary", "BookTitle", "CategoryId" },
                values: new object[,]
                {
                    { 1, 20m, "Nutuk", "Devlet", null },
                    { 2, 270m, "Vatan ", "Vatan", null },
                    { 3, 70m, "Silah ", "Silah", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science Description", "Computer Science" },
                    { 2, "Network Description", "Network " },
                    { 3, "Database Description", "Database " }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 2 },
                    { 3, 2, 1 },
                    { 4, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "BookDetailId", "BookCity", "BookCountry", "BookISBN", "BookId", "BookLanguage", "BookNumberOfPage", "BookPublisher" },
                values: new object[] { 1, "Samsun", "Turkey", "1234-5456-1234", 1, "Turkish", 100, "Samsun University" });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId",
                unique: true,
                filter: "[BookId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
