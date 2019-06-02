using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobPost.BL.DALInterfaces.Finders.Base
{
    public interface IFinder<T>
    {
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}
