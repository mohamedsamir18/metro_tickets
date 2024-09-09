using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketPricing2.Migrations
{
    /// <inheritdoc />
    public partial class AddistransitionToStationLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "istransition",
                table: "StationsLine",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "istransition",
                table: "StationsLine");
        }
    }
}
