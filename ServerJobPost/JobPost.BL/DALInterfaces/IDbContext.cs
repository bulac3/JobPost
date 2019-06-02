using JobPost.BL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPost.BL.DALInterfaces
{
    public interface IDbContext
    {
        DbSet<Job> Jobs { get; set; }
    }
}
