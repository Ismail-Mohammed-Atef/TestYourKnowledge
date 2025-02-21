using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateusers6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnswersHistoryUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserOfExamId",
                table: "UserAnswersHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswersHistory_UserOfExamId",
                table: "UserAnswersHistory",
                column: "UserOfExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory",
                column: "UserOfExamId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswersHistory_UserOfExamId",
                table: "UserAnswersHistory");

            migrationBuilder.DropColumn(
                name: "UserOfExamId",
                table: "UserAnswersHistory");

            migrationBuilder.CreateTable(
                name: "UserAnswersHistoryUsers",
                columns: table => new
                {
                    UserHistoryId = table.Column<int>(type: "int", nullable: false),
                    UsersOfExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswersHistoryUsers", x => new { x.UserHistoryId, x.UsersOfExamId });
                    table.ForeignKey(
                        name: "FK_UserAnswersHistoryUsers_UserAnswersHistory_UserHistoryId",
                        column: x => x.UserHistoryId,
                        principalTable: "UserAnswersHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserAnswersHistoryUsers_Users_UsersOfExamId",
                        column: x => x.UsersOfExamId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswersHistoryUsers_UsersOfExamId",
                table: "UserAnswersHistoryUsers",
                column: "UsersOfExamId");
        }
    }
}
