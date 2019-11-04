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
                    Created = table.Column<DateTime>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
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
                columns: new[] { "Id", "Created", "Description", "DisplayOrder", "Icon", "IsPublished", "Link", "Name", "ParentId", "Updated" },
                values: new object[,]
                {
                    { new Guid("b9414515-f75e-4aa2-a2c2-eac2e0cdc706"), new DateTime(2019, 10, 30, 14, 44, 6, 520, DateTimeKind.Local).AddTicks(5223), "", 100, "", true, "/Channel/Anime", "动漫", null, null },
                    { new Guid("898365a3-88c3-4a4f-94b9-a5c3f220ed0b"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4847), "", 200, "", true, "/Channel/Film", "电影", null, null },
                    { new Guid("d8abeb69-df56-42b6-9c12-e16274c5baea"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4929), "", 300, "", true, "/Channel/TV", "电视剧", null, null },
                    { new Guid("2c38f9bd-8603-42ca-8707-8a9ab7b4e945"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4934), "", 400, "", true, "/Channel/Documentary", "纪录片", null, null },
                    { new Guid("6ab37c0e-7a63-4f88-8ba6-8ed411436ea4"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4936), "", 500, "", true, "/Channel/PhysicalEducation", "体育", null, null },
                    { new Guid("4174ef5c-b5ac-4b09-9169-4cc507c43720"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4938), "", 600, "", true, "/Channel/Military", "军事", null, null },
                    { new Guid("9a301aca-3d51-430c-bbc7-50353fba98fe"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4953), "", 700, "", true, "/Channel/History", "历史", null, null },
                    { new Guid("b43c0f7b-f074-439d-bb3b-31fc48442924"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4955), "", 800, "", true, "/Channel/Technology", "科技", null, null },
                    { new Guid("2a37341f-1280-40b9-a51f-fb567e3a843a"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4957), "", 900, "", true, "/Channel/Program", "编程", null, null },
                    { new Guid("82ee39df-d97a-4989-af61-f1c71d4ebf6f"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4959), "", 1000, "", true, "/Channel/Game", "游戏", null, null },
                    { new Guid("f8081e01-e924-4a2f-8c22-2e0660416ae3"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4962), "", 1100, "", true, "/Channel/Original", "原创", null, null },
                    { new Guid("4b743707-c824-418e-a2eb-eb5e839b0502"), new DateTime(2019, 10, 30, 14, 44, 6, 521, DateTimeKind.Local).AddTicks(4964), "", 1200, "", true, "/Channel/Education", "教育", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
