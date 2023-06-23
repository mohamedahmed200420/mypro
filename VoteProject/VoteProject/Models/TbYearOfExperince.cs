using System;
using System.Collections.Generic;

namespace VoteProject.Models;

public partial class TbYearOfExperince
{
    public int YearOfExperinceId { get; set; }

    public int Year { get; set; }

    public virtual ICollection<TbVoteResult> TbVoteResults { get; set; } = new List<TbVoteResult>();
}
