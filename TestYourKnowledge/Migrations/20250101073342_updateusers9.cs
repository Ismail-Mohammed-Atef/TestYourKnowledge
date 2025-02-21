using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateusers9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory",
                column: "UserOfExamId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswersHistory_Users_UserOfExamId",
                table: "UserAnswersHistory",
                column: "UserOfExamId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
