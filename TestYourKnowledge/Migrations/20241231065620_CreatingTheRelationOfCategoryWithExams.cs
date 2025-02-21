using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class CreatingTheRelationOfCategoryWithExams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "examCategoryId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_examCategoryId",
                table: "Exams",
                column: "examCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_ExamCategories_examCategoryId",
                table: "Exams",
                column: "examCategoryId",
                principalTable: "ExamCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_ExamCategories_examCategoryId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_examCategoryId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "examCategoryId",
                table: "Exams");
        }
    }
}
