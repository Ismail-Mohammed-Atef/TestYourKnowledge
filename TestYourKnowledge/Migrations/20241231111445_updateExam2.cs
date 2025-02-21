using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateExam2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Exams_CreatorId",
                table: "Exams",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_CreatorId",
                table: "Exams",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_CreatorId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CreatorId",
                table: "Exams");
        }
    }
}
