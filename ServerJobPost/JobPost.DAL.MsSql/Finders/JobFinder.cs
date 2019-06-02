using JobPost.BL.DALInterfaces.Finders;
using JobPost.BL.Models;
using JobPost.DAL.MsSql.Finders.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.DAL.MsSql.Finders
{
    public class JobFinder : Finder<Job>, IJobFinder
    {
        public JobFinder(JobPostContext context) : base(context.Jobs)
        { }

        public Task<Job> GetById(Guid id)
        {
            return _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
