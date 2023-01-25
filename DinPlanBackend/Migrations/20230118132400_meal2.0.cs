using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinPlanBackend.Migrations
{
    /// <inheritdoc />
    public partial class meal20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Meals",
                newName: "CookNotes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CookNotes",
                table: "Meals",
                newName: "Description");
        }
    }
}
