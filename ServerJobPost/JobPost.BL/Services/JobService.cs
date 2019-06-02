using JobPost.BL.DALInterfaces;
using JobPost.BL.Models;
using JobPost.BL.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPost.BL.Services
{
    public class JobService : RepositoryService<Job>
    {
        public JobService(IJobRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
