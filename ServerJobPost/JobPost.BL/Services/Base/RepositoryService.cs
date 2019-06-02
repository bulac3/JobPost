using JobPost.BL.DALInterfaces;
using JobPost.BL.DALInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.BL.Services.Base
{
    public class RepositoryService<T>
        where T : class
    {
        protected readonly IRepository<T> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public RepositoryService(
            IRepository<T> repository,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual Task Add(T entity)
        {
            _repository.Add(entity);
            return _unitOfWork.SaveChanges();
        }

        public virtual Task SaveEdited(T entity)
        {
            return _unitOfWork.SaveChanges();
        }

        public virtual Task Delete(T entity)
        {
            _repository.Delete(entity);
            return _unitOfWork.SaveChanges();
        }
    }
}
