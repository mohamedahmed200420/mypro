using VoteProject.Models;
namespace VoteProject.Bl
{
    public class ClsVoteResult : IbusinussLayer<TbVoteResult>
    {
        VoteContext ctx=new VoteContext();
        public void Add(TbVoteResult table)
        {
            ctx.TbVoteResults.Add(table);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var colum= GetbyId(id);
            ctx.TbVoteResults.Remove(colum);
            ctx.SaveChanges();
        }

        public List<TbVoteResult> GetAll()
        {
           return ctx.TbVoteResults.ToList();
        }

        public TbVoteResult GetbyId(int id)
        {
            return ctx.TbVoteResults.Where(a => a.IdOfDataBase == id).FirstOrDefault();
        }
    }
}
