using JobPost.BL.DALInterfaces;
using JobPost.BL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPost.DAL.MsSql
{
    public class JobPostContext: DbContext, IDbContext
    {
        public JobPostContext(DbContextOptions<JobPostContext> options) : base(options) { }

        public virtual DbSet<Job> Jobs { get; set; }
    }
}
