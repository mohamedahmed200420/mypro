using System;
using System.Collections.Generic;

namespace VoteProject.Models;

public partial class TbJob
{
    public int JobId { get; set; }

    public string JobName { get; set; } = null!;

    public virtual ICollection<TbVoteResult> TbVoteResults { get; set; } = new List<TbVoteResult>();
}
