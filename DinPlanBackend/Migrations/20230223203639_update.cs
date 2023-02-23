using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinPlanBackend.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Users_Userid",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Meals",
                newName: "Memberid");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_Userid",
                table: "Meals",
                newName: "IX_Meals_Memberid");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Members_Memberid",
                table: "Meals",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Members_Memberid",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "Memberid",
                table: "Meals",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_Memberid",
                table: "Meals",
                newName: "IX_Meals_Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Users_Userid",
                table: "Meals",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
