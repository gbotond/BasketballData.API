using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballData.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 5, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HomeTeamId = table.Column<Guid>(nullable: false),
                    VisitorTeamId = table.Column<Guid>(nullable: false),
                    Score = table.Column<string>(maxLength: 15, nullable: false),
                    Started = table.Column<DateTimeOffset>(nullable: false),
                    Finished = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_VisitorTeamId",
                        column: x => x.VisitorTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"), "Boston", "Boston Celtics", "BOS" },
                    { new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"), "Los Angeles", "Los Angeles Lakers", "LAL" },
                    { new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"), "Salt Lake City", "Utah Jazz", "UTA" },
                    { new Guid("0f759185-706d-4505-bf7e-0062873ac768"), "Chicago", "Chicago Bulls", "CHI" },
                    { new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"), "Houston", "Houston Rockets", "HOU" },
                    { new Guid("4bace877-9041-4870-8f2b-67674aa5d428"), "Orlando", "Orlando Magic", "ORL" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Finished", "HomeTeamId", "Score", "Started", "VisitorTeamId" },
                values: new object[,]
                {
                    { new Guid("70bccd7b-ef46-4806-8435-a4481e2baf41"), new DateTimeOffset(new DateTime(2008, 6, 5, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"), "88 - 98", new DateTimeOffset(new DateTime(2008, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16") },
                    { new Guid("fa54d4c4-83a3-4756-a70b-7e0741badb9b"), new DateTimeOffset(new DateTime(2008, 6, 8, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"), "102 - 108", new DateTimeOffset(new DateTime(2008, 6, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16") },
                    { new Guid("e9aa7ddb-908c-4c98-9799-3e569aa0ccf2"), new DateTimeOffset(new DateTime(2008, 6, 10, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"), "81 - 87", new DateTimeOffset(new DateTime(2008, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452") },
                    { new Guid("ce44335f-c4d7-47f8-b604-4f55156fc4b5"), new DateTimeOffset(new DateTime(2008, 6, 12, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"), "97 - 91", new DateTimeOffset(new DateTime(2008, 6, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452") },
                    { new Guid("ce5bbca2-f7d1-4f88-ba0d-537553976d4b"), new DateTimeOffset(new DateTime(2008, 6, 15, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"), "98 - 103", new DateTimeOffset(new DateTime(2008, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452") },
                    { new Guid("14310377-4f4d-479c-bdd9-688e48fb448e"), new DateTimeOffset(new DateTime(2008, 6, 17, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"), "92 - 131", new DateTimeOffset(new DateTime(2008, 6, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16") },
                    { new Guid("07b15293-71f9-4edf-a17f-bdea5c06c720"), new DateTimeOffset(new DateTime(1998, 6, 3, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"), "85 - 88", new DateTimeOffset(new DateTime(1998, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768") },
                    { new Guid("f02f04fd-8962-4acd-a59d-7777523695a7"), new DateTimeOffset(new DateTime(1998, 6, 5, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"), "93 - 88", new DateTimeOffset(new DateTime(1998, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768") },
                    { new Guid("94b04b61-90fe-46fe-9f43-329fea2e1d47"), new DateTimeOffset(new DateTime(1998, 6, 7, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768"), "54 - 96", new DateTimeOffset(new DateTime(1998, 6, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3") },
                    { new Guid("804781b3-b287-4c20-8883-ef8ca2c6b7e0"), new DateTimeOffset(new DateTime(1998, 6, 10, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768"), "82 - 86", new DateTimeOffset(new DateTime(1998, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3") },
                    { new Guid("1e1fac1a-476f-408e-8841-6f8d8eea3a15"), new DateTimeOffset(new DateTime(1998, 6, 12, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768"), "83 - 81", new DateTimeOffset(new DateTime(1998, 6, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3") },
                    { new Guid("bb4018db-5c44-4fd3-9a94-39b5cfdb98ee"), new DateTimeOffset(new DateTime(1998, 6, 14, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"), "87 - 86", new DateTimeOffset(new DateTime(1998, 6, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0f759185-706d-4505-bf7e-0062873ac768") },
                    { new Guid("17e4060c-91ce-4567-8512-634d92979092"), new DateTimeOffset(new DateTime(1995, 6, 7, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4bace877-9041-4870-8f2b-67674aa5d428"), "120 - 118 (OT)", new DateTimeOffset(new DateTime(1995, 6, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a") },
                    { new Guid("7eeb7403-c229-4ddc-a07a-6a7d8961d497"), new DateTimeOffset(new DateTime(1995, 6, 9, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4bace877-9041-4870-8f2b-67674aa5d428"), "117 - 106", new DateTimeOffset(new DateTime(1995, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a") },
                    { new Guid("d691ac38-9b9c-41ab-996c-7ca4bc861163"), new DateTimeOffset(new DateTime(1995, 6, 11, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"), "103 - 106", new DateTimeOffset(new DateTime(1995, 6, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4bace877-9041-4870-8f2b-67674aa5d428") },
                    { new Guid("1cd65873-3e9b-4886-a8f3-5ab9cb5cc5bd"), new DateTimeOffset(new DateTime(1995, 6, 14, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"), "101 - 113", new DateTimeOffset(new DateTime(1995, 6, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4bace877-9041-4870-8f2b-67674aa5d428") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeamId",
                table: "Games",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_VisitorTeamId",
                table: "Games",
                column: "VisitorTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
