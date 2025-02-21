using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateuserhistoryyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamUserAnswersHistory");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ExamUserAnswersHistory",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamUserAnswersHistory", x => new { x.ExamId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ExamUserAnswersHistory_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamUserAnswersHistory_UserAnswersHistory_UsersId",
                        column: x => x.UsersId,
                        principalTable: "UserAnswersHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamUserAnswersHistory_UsersId",
                table: "ExamUserAnswersHistory",
                column: "UsersId");
        }
    }
}
