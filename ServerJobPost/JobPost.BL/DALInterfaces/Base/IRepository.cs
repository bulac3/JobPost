using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobPost.BL.DALInterfaces.Base
{
    public interface IRepository<T> where T : class
    {
        IDbContext Context { get; }
        IQueryable<T> AsQueryable();
        void Add(T entity);
        void Delete(T entity);
    }
}
