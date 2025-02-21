using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateuserhistoryyyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswersHistory_Exams_ExamId",
                table: "UserAnswersHistory");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswersHistory_ExamId",
                table: "UserAnswersHistory");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "UserAnswersHistory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "UserAnswersHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswersHistory_ExamId",
                table: "UserAnswersHistory",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswersHistory_Exams_ExamId",
                table: "UserAnswersHistory",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }
    }
}
