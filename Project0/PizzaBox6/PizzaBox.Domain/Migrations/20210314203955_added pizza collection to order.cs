using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Domain.Migrations
{
    public partial class addedpizzacollectiontoorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzaId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PizzaId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "AOrderAPizza",
                columns: table => new
                {
                    AOrdersAOrderId = table.Column<int>(type: "int", nullable: false),
                    PizzasAPizzaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AOrderAPizza", x => new { x.AOrdersAOrderId, x.PizzasAPizzaId });
                    table.ForeignKey(
                        name: "FK_AOrderAPizza_Orders_AOrdersAOrderId",
                        column: x => x.AOrdersAOrderId,
                        principalTable: "Orders",
                        principalColumn: "AOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AOrderAPizza_Pizzas_PizzasAPizzaId",
                        column: x => x.PizzasAPizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "APizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AOrderAPizza_PizzasAPizzaId",
                table: "AOrderAPizza",
                column: "PizzasAPizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AOrderAPizza");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaId",
                table: "Orders",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzas_PizzaId",
                table: "Orders",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "APizzaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
