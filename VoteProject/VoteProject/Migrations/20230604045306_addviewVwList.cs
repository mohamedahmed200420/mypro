using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteProject.Migrations
{
    /// <inheritdoc />
    public partial class addviewVwList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view VwList
as
SELECT        dbo.TbVote.voteName, dbo.TbVotesOption.options, dbo.TbVoteResult.name
FROM            dbo.TbVoteResult INNER JOIN
                         dbo.TbVotesOption ON dbo.TbVoteResult.votesOptionId = dbo.TbVotesOption.voteOptionId INNER JOIN
                         dbo.TbVote ON dbo.TbVotesOption.voteId = dbo.TbVote.voteId
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
