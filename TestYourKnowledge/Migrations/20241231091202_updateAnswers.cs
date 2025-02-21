using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestYourKnowledge.Migrations
{
    /// <inheritdoc />
    public partial class updateAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RightAnswer",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RightAnswer",
                table: "Answers");
        }
    }
}
