using JobPost.BL.DALInterfaces.Finders.Base;
using JobPost.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.BL.DALInterfaces.Finders
{
    public interface IJobFinder : IFinder<Job>
    {
        Task<Job> GetById(Guid id);
    }
}
