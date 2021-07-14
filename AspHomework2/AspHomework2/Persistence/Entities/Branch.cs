using System.Collections.Generic;

namespace AspHomework2.Persistence.Entities
{
    public class Branch
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
    }
}