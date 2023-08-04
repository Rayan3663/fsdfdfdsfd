using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class tesCheck2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_status_orders_OrderID",
                table: "status");

            migrationBuilder.DropForeignKey(
                name: "FK_status_user_UserID",
                table: "status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_status",
                table: "status");

            migrationBuilder.RenameTable(
                name: "status",
                newName: "payment");

            migrationBuilder.RenameIndex(
                name: "IX_status_UserID",
                table: "payment",
                newName: "IX_payment_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_status_OrderID",
                table: "payment",
                newName: "IX_payment_OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment",
                table: "payment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_payment_orders_OrderID",
                table: "payment",
                column: "OrderID",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_user_UserID",
                table: "payment",
                column: "UserID",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payment_orders_OrderID",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_user_UserID",
                table: "payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment",
                table: "payment");

            migrationBuilder.RenameTable(
                name: "payment",
                newName: "status");

            migrationBuilder.RenameIndex(
                name: "IX_payment_UserID",
                table: "status",
                newName: "IX_status_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_payment_OrderID",
                table: "status",
                newName: "IX_status_OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_status",
                table: "status",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_status_orders_OrderID",
                table: "status",
                column: "OrderID",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_status_user_UserID",
                table: "status",
                column: "UserID",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
