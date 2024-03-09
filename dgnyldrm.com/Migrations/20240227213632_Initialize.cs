using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dgnyldrm.com.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: true),
                    AuthorEmail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumcular",
                columns: table => new
                {
                    YorumcuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YorumcuName = table.Column<string>(type: "TEXT", nullable: true),
                    YorumcuLastName = table.Column<string>(type: "TEXT", nullable: true),
                    YorumcuEmail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumcular", x => x.YorumcuId);
                });

            migrationBuilder.CreateTable(
                name: "Yazilarim",
                columns: table => new
                {
                    NewsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: true),
                    AuthorID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazilarim", x => x.NewsID);
                    table.ForeignKey(
                        name: "FK_Yazilarim_Yazarlar_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Yazarlar",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesNews",
                columns: table => new
                {
                    CategoriesCategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    NewsID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesNews", x => new { x.CategoriesCategoryID, x.NewsID });
                    table.ForeignKey(
                        name: "FK_CategoriesNews_Kategoriler_CategoriesCategoryID",
                        column: x => x.CategoriesCategoryID,
                        principalTable: "Kategoriler",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesNews_Yazilarim_NewsID",
                        column: x => x.NewsID,
                        principalTable: "Yazilarim",
                        principalColumn: "NewsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentContent = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    YorumcuId = table.Column<int>(type: "INTEGER", nullable: false),
                    NewsID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.CommentsId);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Yazilarim_NewsID",
                        column: x => x.NewsID,
                        principalTable: "Yazilarim",
                        principalColumn: "NewsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Yorumcular_YorumcuId",
                        column: x => x.YorumcuId,
                        principalTable: "Yorumcular",
                        principalColumn: "YorumcuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "CategoryID", "CategoryName", "Slug" },
                values: new object[,]
                {
                    { 1, "Javascript", "Javascript" },
                    { 2, "AspCore", "AspCore" },
                    { 3, "Python", "Python" },
                    { 4, "C#", "C#" },
                    { 5, "Php", "Php" }
                });

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "AuthorID", "AuthorEmail", "AuthorName" },
                values: new object[,]
                {
                    { 1, "dgnyldrm7@icloud.com", "Doğan" },
                    { 2, "merve7@icloud.com", "Merve" }
                });

            migrationBuilder.InsertData(
                table: "Yorumcular",
                columns: new[] { "YorumcuId", "YorumcuEmail", "YorumcuLastName", "YorumcuName" },
                values: new object[,]
                {
                    { 1, "dgn@mail.com", "Yıldırım", "Doğan" },
                    { 2, "diyar@mail.com", "Ahmet", "Diyar" },
                    { 3, "kemal@mail.com", "Tanca", "Kemal" },
                    { 4, "abc@mail.com", "Harfes", "Abece" }
                });

            migrationBuilder.InsertData(
                table: "Yazilarim",
                columns: new[] { "NewsID", "AuthorID", "Content", "CreatedTime", "IsActive", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Yazının içeriği 1", new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9913), true, "php-ile-kodlama", "Php ile kodlama" },
                    { 2, 1, "Yazının içeriği 2", new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9925), true, "js-ile-kodlama", "JavaScript ile kodlama" },
                    { 3, 2, "Yazının içeriği 3", new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9927), true, "python-ile-kodlama", "Python ile kodlama" },
                    { 4, 2, "Yazının içeriği 4", new DateTime(2024, 2, 28, 0, 36, 31, 631, DateTimeKind.Local).AddTicks(9971), true, "csharp-ile-kodlama", "C# ile kodlama" }
                });

            migrationBuilder.InsertData(
                table: "Yorumlar",
                columns: new[] { "CommentsId", "CommentContent", "CreatedTime", "NewsID", "YorumcuId" },
                values: new object[,]
                {
                    { 1, "Gerçekten Çok Beğendim.Sağ olun!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, "Çok yardımcı oldunuz.Sağ olun !", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, "Başka örnekler var mı ?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 4, "Çok iyisiniz.Allah yardımcımız olsun bu alanda uzmanlaşmak gerçekten çok zor. HAHAHAHHAHA bu bir test verisi ama ben daha çok şey yazarak aslında bazı şeylere çözüm üretmeye çalışıyorum!!!!!", new DateTime(2024, 2, 28, 0, 36, 31, 632, DateTimeKind.Local).AddTicks(198), 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesNews_NewsID",
                table: "CategoriesNews",
                column: "NewsID");

            migrationBuilder.CreateIndex(
                name: "IX_Yazilarim_AuthorID",
                table: "Yazilarim",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_NewsID",
                table: "Yorumlar",
                column: "NewsID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_YorumcuId",
                table: "Yorumlar",
                column: "YorumcuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesNews");

            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yazilarim");

            migrationBuilder.DropTable(
                name: "Yorumcular");

            migrationBuilder.DropTable(
                name: "Yazarlar");
        }
    }
}
