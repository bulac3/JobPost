using JobPost.BL.DALInterfaces;
using JobPost.BL.Models;
using JobPost.DAL.MsSql.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPost.DAL.MsSql.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(JobPostContext context) : base(context)
        {
        }
    }
}
