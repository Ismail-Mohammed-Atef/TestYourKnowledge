using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateexam4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAnswersHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RightAnswers = table.Column<int>(type: "int", nullable: false),
                    WrongAnswers = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswersHistory", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamUserAnswersHistory");

            migrationBuilder.DropTable(
                name: "UserAnswersHistory");
        }
    }
}
