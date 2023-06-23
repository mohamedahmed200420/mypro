using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using VoteProject.Bl;
using VoteProject.Migrations;
using VoteProject.Models;

namespace VoteProject.Controllers
{
    public class VwAllData
    {
        public string name { get; set; }
        public string option { get; set; }
        public string voteName { get; set; }
        public int idOfDataBase { get; set; }
    }
    public class HomeController : Controller
    {
        ClsVoteResult oClsVoteResult = new ClsVoteResult();
        VoteContext ctx = new VoteContext();
        public IActionResult Index()
        {
            var model = ctx.TbVotes.ToList();
            ViewBag.Votes = model;
            return View();
        }
        public IActionResult List()
        {
            var AllData = (from name in ctx.TbVoteResults
                           join
                               option in ctx.TbVotesOptions on name.VotesOptionId equals option.VoteOptionId
                           join voteName in ctx.TbVotes on option.VoteId equals voteName.VoteId
                           select new VwAllData
                           {
                               name = name.Name,
                               option = option.Options,
                               voteName = voteName.VoteName,
                               idOfDataBase = name.IdOfDataBase
                           }).ToList();


            return View(AllData);
        }
        //[HttpPost]
        public IActionResult vote(int id, TbVote vote, TbVoteResult RESULT)
        {
            if (id != 0)
            {
                RESULT = oClsVoteResult.GetbyId(id);
                var editOption = ctx.TbVotesOptions.Where(a => a.VoteOptionId == RESULT.VotesOptionId).FirstOrDefault();
                vote = ctx.TbVotes.Where(v => v.VoteId == editOption.VoteId).FirstOrDefault();
            }
            var op = ctx.TbVotesOptions.Where(a => a.VoteId == vote.VoteId).ToList();
            ViewBag.option = op;
            ViewBag.jobs = ctx.TbJobs.ToList();
            ViewBag.yearOfExeperince = ctx.TbYearOfExperinces.ToList();
            return View(RESULT);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(TbVoteResult voteResult)
        {
            var alldata = ctx.TbVoteResults.ToList();
            if (!ModelState.IsValid)
            {
                return RedirectToAction("vote", voteResult);
            }

            var item = alldata.Where(a => a.VoteResultId == voteResult.VoteResultId).FirstOrDefault();
            if (voteResult.IdOfDataBase == 0)
            {

                var id = ctx.TbVoteResults.Max(a => a.IdOfDataBase);
                if (id == 0)
                {
                    id = 1;

                }
                else
                {
                    id++;
                }
                voteResult.IdOfDataBase = id;
                ctx.TbVoteResults.Add(voteResult);
            }
            else
            {

                //if (voteResult.VoteResultId == 0)
                //{
                //    voteResult.VoteResultId = (ctx.TbVoteResults.Max(a => a.VoteResultId));
                //}
                //var colum = ctx.TbVoteResults.Where(a => a.IdOfDataBase == voteResult.IdOfDataBase).FirstOrDefault();
                //voteResult.VoteResultId = colum.VoteResultId;
                var colum = ctx.TbVoteResults.Where(a => a.IdOfDataBase == voteResult.IdOfDataBase).FirstOrDefault();
                colum.Age=voteResult.Age;
                colum.VotesOptionId = voteResult.VotesOptionId;
                colum.Notes=voteResult.Notes;
                colum.Name=voteResult.Name;
                colum.JobId=voteResult.JobId;
                colum.YearOfExperienceId=voteResult.YearOfExperienceId;
                ctx.Entry(colum).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            ctx.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            oClsVoteResult.Delete(id);

            return RedirectToAction("List");
        }

    }
}
