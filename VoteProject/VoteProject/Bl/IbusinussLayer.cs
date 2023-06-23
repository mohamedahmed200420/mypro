namespace VoteProject.Bl
{
    public interface IbusinussLayer<t>
    {
        public void Add(t table);
        public void Delete(int id);
        public List<t> GetAll();    
        public t GetbyId(int id);
    }
}
