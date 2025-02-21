using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateusers5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswersHistoryUsers_Users_UsersOfExamId",
                        column: x => x.UsersOfExamId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswersHistoryUsers_UsersOfExamId",
                table: "UserAnswersHistoryUsers",
                column: "UsersOfExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnswersHistoryUsers");
        }
    }
}
