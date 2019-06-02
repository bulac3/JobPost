using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.BL.DALInterfaces
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}
