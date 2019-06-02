using System;
using System.Collections.Generic;
using System.Text;

namespace JobPost.BL.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public string Description { get; set; }
    }
}
