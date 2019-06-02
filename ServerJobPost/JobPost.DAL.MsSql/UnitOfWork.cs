using JobPost.BL.DALInterfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.DAL.MsSql
{
    public class UnitOfWork : IUnitOfWork
    {
        private JobPostContext _context { get; set; }

        public UnitOfWork(JobPostContext context)
        {
            _context = context;
        }

        public IDbContextTransaction StartTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public Task SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
