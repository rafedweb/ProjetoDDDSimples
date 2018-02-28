using ProjetoDDDSimplificado.Data.Helpers;
using ProjetoDDDSimplificado.Domain.Entidades.Base;
using ProjetoDDDSimplificado.Domain.Helpers;
using ProjetoDDDSimplificado.Domain.Repositories;
using System;
using System.Linq;

namespace ProjetoDDDSimplificado.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private UnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void CreateOrUpdate(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByCodigo(int Codigo)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
       
    }
}
