using System;
using System.Collections.Generic;

namespace VoteProject.Models;

public partial class TbVotesOption
{
    public int VoteOptionId { get; set; }

    public int VoteId { get; set; }

    public string Options { get; set; } = null!;

    public virtual ICollection<TbVoteResult> TbVoteResults { get; set; } = new List<TbVoteResult>();

    public virtual TbVote Vote { get; set; } = null!;
}
