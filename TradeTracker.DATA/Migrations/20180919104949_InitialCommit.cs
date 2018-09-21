using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeTracker.DATA.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Tradedpair = table.Column<int>(name: "Traded pair", nullable: false),
                    Ordertype = table.Column<int>(name: "Order type", nullable: false),
                    Tradestatus = table.Column<int>(name: "Trade status", nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Priceofexecution = table.Column<double>(name: "Price of execution", nullable: false),
                    Executiondate = table.Column<DateTime>(name: "Execution date", nullable: true),
                    Priceofclosing = table.Column<double>(name: "Price of closing", nullable: true),
                    Closedate = table.Column<DateTime>(name: "Close date", nullable: true),
                    StopLoss = table.Column<double>(name: "Stop/Loss", nullable: true),
                    TakeProfit = table.Column<double>(name: "Take/Profit", nullable: true),
                    Swap = table.Column<double>(nullable: true),
                    Commissions = table.Column<double>(nullable: true),
                    Entryreason = table.Column<int>(name: "Entry reason", nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "Id", "Close date", "Price of closing", "Commissions", "Execution date", "Price of execution", "Image", "Notes", "Order type", "Quantity", "Entry reason", "Stop/Loss", "Swap", "Take/Profit", "Traded pair", "Trade status" },
                values: new object[] { "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, new DateTime(2018, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.168, null, "Market enter after US CPI data release. Do not hold overnight!!!", 0, 1.0, 15, 1.16, 0.0, 1.18, 0, 0 });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "Id", "Close date", "Price of closing", "Commissions", "Execution date", "Price of execution", "Image", "Notes", "Order type", "Quantity", "Entry reason", "Stop/Loss", "Swap", "Take/Profit", "Traded pair", "Trade status" },
                values: new object[] { "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, new DateTime(2018, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.908, null, "Long term trade", 5, 1.0, 7, 0.913, 0.0, 0.8812, 4, 1 });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "Id", "Close date", "Price of closing", "Commissions", "Execution date", "Price of execution", "Image", "Notes", "Order type", "Quantity", "Entry reason", "Stop/Loss", "Swap", "Take/Profit", "Traded pair", "Trade status" },
                values: new object[] { "3", new DateTime(2018, 9, 18, 9, 15, 0, 0, DateTimeKind.Unspecified), 1.779, 0.0, new DateTime(2018, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.771, null, "Scalping. Following the news feeds and expectations for euro consolidation. Time horizon is less than 12 hours", 0, 5.0, 21, 1.769, -0.1, 1.779, 5, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
