using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteProject.Migrations
{
    /// <inheritdoc />
    public partial class newColum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdOfDataBase",
                table: "TbVoteResult",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOfDataBase",
                table: "TbVoteResult");
        }
    }
}
