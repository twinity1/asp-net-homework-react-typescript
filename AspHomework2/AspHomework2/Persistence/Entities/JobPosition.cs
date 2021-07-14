namespace AspHomework2.Persistence.Entities
{
    public class JobPosition
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public virtual Branch Branch { get; set; }
        
        public int BranchId { get; set; }
    }
}