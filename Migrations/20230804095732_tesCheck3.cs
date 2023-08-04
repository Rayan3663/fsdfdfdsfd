using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class tesCheck3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
