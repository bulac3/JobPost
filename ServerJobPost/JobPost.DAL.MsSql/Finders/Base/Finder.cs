using JobPost.BL.DALInterfaces.Finders.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.DAL.MsSql.Finders.Base
{
    public class Finder<T>
        where T : class
    {
        protected DbSet<T> _dbSet { get; set; }

        public Finder(DbSet<T> repository)
        {
            _dbSet = repository;
        }

        public virtual IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}
