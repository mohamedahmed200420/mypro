using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VoteProject.Models;

public partial class TbVoteResult
{
    [ValidateNever]
    public int VoteResultId { get; set; }
    [Required(ErrorMessage ="please enter user name")]
    
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "please enter job name")]
    public int JobId { get; set; }
    [Required(ErrorMessage = "please enter user year of experience  ")]
    public int YearOfExperienceId { get; set; }
    [Required(ErrorMessage = "please enter user Age ")]
    
    public int Age { get; set; }
    [ValidateNever]
    public string? Notes { get; set; }
    [Required(ErrorMessage = "please enter user option ")]
    public int VotesOptionId { get; set; }
    [ValidateNever]
    public int IdOfDataBase{ get; set; }
    [ValidateNever]
    public virtual TbJob Job { get; set; } = null!;
    [ValidateNever]
    public virtual TbVotesOption VotesOption { get; set; } = null!;
    [ValidateNever]
    public virtual TbYearOfExperince YearOfExperience { get; set; } = null!;
}
