using System;
using System.Collections.Generic;

namespace VoteProject.Models;

public partial class TbVote
{
    public int VoteId { get; set; }

    public string VoteName { get; set; } = null!;

    public virtual ICollection<TbVotesOption> TbVotesOptions { get; set; } = new List<TbVotesOption>();
}
