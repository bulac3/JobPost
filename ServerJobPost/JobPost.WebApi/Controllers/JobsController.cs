using JobPost.BL.DALInterfaces.Finders;
using JobPost.BL.Models;
using JobPost.BL.Services;
using JobPost.DAL.MsSql.Finders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPost.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private JobService _jobService;
        private IJobFinder _jobFinder;

        public JobsController(
            JobService jobService,
            IJobFinder jobFinder)
        {
            _jobService = jobService;
            _jobFinder = jobFinder;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAll() => Ok(_jobFinder.FindBy(x => true).AsEnumerable());
    }
}
