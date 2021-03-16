using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Domain.Migrations
{
    public partial class addedICollectionstoallinterfaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APizza",
                columns: table => new
                {
                    APizzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizza", x => x.APizzaId);
                });

            migrationBuilder.CreateTable(
                name: "AComponent",
                columns: table => new
                {
                    AComponentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PizzaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AComponent", x => x.AComponentId);
                    table.ForeignKey(
                        name: "FK_AComponent_APizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "APizza",
                        principalColumn: "APizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AOrder",
                columns: table => new
                {
                    AOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AOrder", x => x.AOrderId);
                    table.ForeignKey(
                        name: "FK_AOrder_APizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "APizza",
                        principalColumn: "APizzaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AOrder_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "ACustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AOrder_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "AStoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AComponent_PizzaId",
                table: "AComponent",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_AOrder_CustomerId",
                table: "AOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AOrder_PizzaId",
                table: "AOrder",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_AOrder_StoreId",
                table: "AOrder",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AComponent");

            migrationBuilder.DropTable(
                name: "AOrder");

            migrationBuilder.DropTable(
                name: "APizza");
        }
    }
}
