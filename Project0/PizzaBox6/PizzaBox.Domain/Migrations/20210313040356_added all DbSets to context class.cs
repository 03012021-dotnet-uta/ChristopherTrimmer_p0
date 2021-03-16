using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Domain.Migrations
{
    public partial class addedallDbSetstocontextclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AComponent_APizza_PizzaId",
                table: "AComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_AOrder_APizza_PizzaId",
                table: "AOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_AOrder_Customers_CustomerId",
                table: "AOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_AOrder_Stores_StoreId",
                table: "AOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APizza",
                table: "APizza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AOrder",
                table: "AOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AComponent",
                table: "AComponent");

            migrationBuilder.RenameTable(
                name: "APizza",
                newName: "Pizzas");

            migrationBuilder.RenameTable(
                name: "AOrder",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "AComponent",
                newName: "Components");

            migrationBuilder.RenameIndex(
                name: "IX_AOrder_StoreId",
                table: "Orders",
                newName: "IX_Orders_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_AOrder_PizzaId",
                table: "Orders",
                newName: "IX_Orders_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_AOrder_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_AComponent_PizzaId",
                table: "Components",
                newName: "IX_Components_PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "APizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "AOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Components",
                table: "Components",
                column: "AComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_Pizzas_PizzaId",
                table: "Components",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "APizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "ACustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzas_PizzaId",
                table: "Orders",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "APizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "AStoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Pizzas_PizzaId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzaId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Components",
                table: "Components");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "APizza");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "AOrder");

            migrationBuilder.RenameTable(
                name: "Components",
                newName: "AComponent");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreId",
                table: "AOrder",
                newName: "IX_AOrder_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PizzaId",
                table: "AOrder",
                newName: "IX_AOrder_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "AOrder",
                newName: "IX_AOrder_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Components_PizzaId",
                table: "AComponent",
                newName: "IX_AComponent_PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APizza",
                table: "APizza",
                column: "APizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AOrder",
                table: "AOrder",
                column: "AOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AComponent",
                table: "AComponent",
                column: "AComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AComponent_APizza_PizzaId",
                table: "AComponent",
                column: "PizzaId",
                principalTable: "APizza",
                principalColumn: "APizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AOrder_APizza_PizzaId",
                table: "AOrder",
                column: "PizzaId",
                principalTable: "APizza",
                principalColumn: "APizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AOrder_Customers_CustomerId",
                table: "AOrder",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "ACustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AOrder_Stores_StoreId",
                table: "AOrder",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "AStoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
