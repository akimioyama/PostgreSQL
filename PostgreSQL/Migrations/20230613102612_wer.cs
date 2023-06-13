using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class wer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_role_id1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_role_id1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "role_id1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "HistoryLogins");

            migrationBuilder.CreateIndex(
                name: "IX_Users_role_id",
                table: "Users",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_role_id",
                table: "Users",
                column: "role_id",
                principalTable: "Roles",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_role_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_role_id",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "role_id1",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "HistoryLogins",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_role_id1",
                table: "Users",
                column: "role_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_role_id1",
                table: "Users",
                column: "role_id1",
                principalTable: "Roles",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
