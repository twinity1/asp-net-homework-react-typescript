using System.Collections.Generic;

namespace AspHomework2.Controllers.API.DTOs
{
    public class BranchDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<JobPositionDto> JobPositions { get; set; }
    }
}