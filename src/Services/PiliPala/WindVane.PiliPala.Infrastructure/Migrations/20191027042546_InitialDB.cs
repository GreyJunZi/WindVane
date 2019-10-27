using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindVane.PiliPala.Infrastructure.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "DisplayOrder", "Icon", "IsPublished", "Link", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("59340fa4-5cf3-4c23-bc1c-62afdb7f530f"), "", 100, "", true, "", "动漫", null },
                    { new Guid("6e661f46-6936-4f94-aa16-3941e0933791"), "", 200, "", true, "", "电影", null },
                    { new Guid("5f5ee2d1-f8b2-47c8-9a03-93cbcedb483b"), "", 300, "", true, "", "电视剧", null },
                    { new Guid("4574a54a-10ba-44cd-8e8d-29e0dd75fe90"), "", 400, "", true, "", "纪录片", null },
                    { new Guid("efd186cc-8e9b-4a13-80d8-b8c6d22ebf37"), "", 500, "", true, "", "体育", null },
                    { new Guid("fff0c016-5101-4a40-94e0-2cc1e09f05cb"), "", 600, "", true, "", "军事", null },
                    { new Guid("546f0c89-19a5-4416-81bb-19498d2e9d73"), "", 700, "", true, "", "历史", null },
                    { new Guid("58dc7967-6c87-46e9-a69c-eaedf4313d0c"), "", 800, "", true, "", "科技", null },
                    { new Guid("e7dffac5-9af4-475b-b3e1-370827b851c9"), "", 900, "", true, "", "编程", null },
                    { new Guid("9de3c6c7-3dab-4e3e-8a75-fdbb213f6644"), "", 1000, "", true, "", "游戏", null },
                    { new Guid("3151a9ed-46fb-4111-9f8d-eb55deb65683"), "", 1100, "", true, "", "原创", null },
                    { new Guid("47b055cd-1ae4-43b8-a730-b0a208e3e076"), "", 1200, "", true, "", "教育", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
