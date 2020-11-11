using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_darklook.Migrations
{
    public partial class nguyen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Playstation" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "Reviews" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "DateTime", "ImageUrl", "Title" },
                values: new object[] { 1, 1, " lorem very carrots, enhanced undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who suspend basketball very pregnant .... ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "./img/blog/1.jpg", "The best online game is out now!" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "DateTime", "ImageUrl", "Title" },
                values: new object[] { 2, 2, " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed tempor and vitality, so that the labor and sorrow, some important things to do eiusmod. Ultrices gravida .... Who hung up the very hard work ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "./img/blog/2.jpg", "Top 5 best games in november" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "DateTime", "ImageUrl", "Title" },
                values: new object[] { 3, 3, " To be honest, the main undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who recommended that pregnant basketball ncididunt to work .... ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "./img/blog/3.jpg", "The best online game is out now!" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
