using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Arhitecture.Data.Migrations
{
    public partial class IntialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginingOfShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingOfShift = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptioners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptioners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAndTimeOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferPerCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferPerCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferPerCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferPerCategories_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OneOffBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneOffBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneOffBills_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OneOffBills_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionerId = table.Column<int>(type: "int", nullable: true),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    RentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentBills_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentBills_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentBills_Subscriptioners_SubscriptionerId",
                        column: x => x.SubscriptionerId,
                        principalTable: "Subscriptioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceBills_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceBills_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceBills_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "DateAndTimeOfIssue", "EmployeeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, new DateTime(2020, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Category G" },
                    { 6, "Category F" },
                    { 5, "Category E" },
                    { 3, "Category C" },
                    { 2, "Category B" },
                    { 1, "Category A" },
                    { 4, "Category D" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BeginingOfShift", "EndingOfShift", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 8, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 8, 0, 2, 0, DateTimeKind.Unspecified), "Matija", "Luketin" },
                    { 2, new DateTime(1, 1, 1, 8, 0, 3, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Ante", "Vuletić" },
                    { 3, new DateTime(1, 1, 1, 20, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Krešimir", "Čondić" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Count" },
                values: new object[,]
                {
                    { 5, 30 },
                    { 6, 80 },
                    { 4, 8 },
                    { 7, 45 },
                    { 2, 10 },
                    { 1, 5 },
                    { 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 21, "Rent G", 80m },
                    { 20, "Rent F", 12m },
                    { 19, "Rent E", 25.5m },
                    { 18, "Rent D", 50m },
                    { 17, "Rent C", 19.5m },
                    { 16, "Rent B", 37.5m },
                    { 15, "Rent A", 35m },
                    { 14, "Service G", 40m },
                    { 13, "Service F", 59m },
                    { 12, "Service E", 20m },
                    { 11, "Service D", 39m },
                    { 9, "Service B", 30m },
                    { 8, "Service A", 50m },
                    { 7, "Artikal G", 7.8m },
                    { 6, "Artikal F", 18m },
                    { 5, "Artikal E", 17.99m },
                    { 4, "Artikal D", 12.79m },
                    { 3, "Artikal C", 13m }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "Artikal B", 15m },
                    { 1, "Artikal A", 10m },
                    { 10, "Service C", 60m }
                });

            migrationBuilder.InsertData(
                table: "Subscriptioners",
                columns: new[] { "Id", "CreditCardNumber", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, "1234123412345678", "Bože", "Topić" },
                    { 1, "1234123412341234", "Michelle", "Šarić" },
                    { 3, "1234123412341235", "Lucia", "Vukorepa" }
                });

            migrationBuilder.InsertData(
                table: "OfferPerCategories",
                columns: new[] { "Id", "CategoryId", "OfferId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 18, 6, 20 },
                    { 15, 5, 19 },
                    { 12, 4, 18 },
                    { 9, 3, 17 },
                    { 6, 2, 16 },
                    { 3, 1, 15 },
                    { 20, 7, 14 },
                    { 17, 6, 13 },
                    { 14, 5, 12 },
                    { 21, 7, 21 },
                    { 8, 3, 10 },
                    { 5, 2, 9 },
                    { 2, 1, 8 },
                    { 11, 4, 11 },
                    { 10, 4, 4 },
                    { 13, 5, 5 },
                    { 16, 6, 6 },
                    { 4, 2, 2 },
                    { 19, 7, 7 },
                    { 7, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InventoryId", "OfferId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 5, 5 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 2, 2, 2 },
                    { 7, 7, 7 },
                    { 6, 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "Id", "OfferId" },
                values: new object[,]
                {
                    { 6, 20 },
                    { 5, 19 },
                    { 4, 18 },
                    { 3, 17 },
                    { 7, 21 },
                    { 1, 15 },
                    { 2, 16 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "OfferId" },
                values: new object[,]
                {
                    { 7, 14 },
                    { 6, 13 },
                    { 5, 12 },
                    { 4, 11 },
                    { 3, 10 },
                    { 2, 9 },
                    { 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "OneOffBills",
                columns: new[] { "Id", "Amount", "BillId", "ProductId" },
                values: new object[,]
                {
                    { 1, 4, 1, 1 },
                    { 2, 6, 1, 2 },
                    { 6, 3, 2, 2 },
                    { 3, 1, 1, 3 },
                    { 7, 16, 2, 3 },
                    { 4, 7, 1, 4 },
                    { 5, 12, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "RentBills",
                columns: new[] { "Id", "BillId", "EndingDate", "RentId", "StartingDate", "SubscriptionerId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, null, new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, null, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, null, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ServiceBills",
                columns: new[] { "Id", "BillId", "EmployeeId", "EndingDateAndTime", "ServiceId", "StartingDateAndTime" },
                values: new object[,]
                {
                    { 1, 3, 1, new DateTime(2020, 12, 4, 8, 0, 2, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 4, 8, 0, 1, 0, DateTimeKind.Unspecified) },
                    { 2, 4, 2, new DateTime(2020, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 12, 14, 8, 0, 2, 0, DateTimeKind.Unspecified) },
                    { 3, 5, 2, new DateTime(2020, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 12, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 6, 2, new DateTime(2020, 12, 4, 8, 0, 2, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 12, 4, 8, 0, 1, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_EmployeeId",
                table: "Bills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferPerCategories_CategoryId",
                table: "OfferPerCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferPerCategories_OfferId",
                table: "OfferPerCategories",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_OneOffBills_BillId",
                table: "OneOffBills",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_OneOffBills_ProductId",
                table: "OneOffBills",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoryId",
                table: "Products",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OfferId",
                table: "Products",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_RentBills_BillId",
                table: "RentBills",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_RentBills_RentId",
                table: "RentBills",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_RentBills_SubscriptionerId",
                table: "RentBills",
                column: "SubscriptionerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_OfferId",
                table: "Rents",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceBills_BillId",
                table: "ServiceBills",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceBills_EmployeeId",
                table: "ServiceBills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceBills_ServiceId",
                table: "ServiceBills",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_OfferId",
                table: "Services",
                column: "OfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferPerCategories");

            migrationBuilder.DropTable(
                name: "OneOffBills");

            migrationBuilder.DropTable(
                name: "RentBills");

            migrationBuilder.DropTable(
                name: "ServiceBills");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Subscriptioners");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
