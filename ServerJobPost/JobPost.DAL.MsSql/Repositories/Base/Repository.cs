using JobPost.BL.DALInterfaces;
using JobPost.BL.DALInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobPost.DAL.MsSql.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T>
             where T : class
    {
        public IDbContext Context { get { return _context; } }
        private JobPostContext _context { get; }

        public Repository(JobPostContext context)
        {
            _context = context;
        }

        public IQueryable<T> AsQueryable()
        {
            return _context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
