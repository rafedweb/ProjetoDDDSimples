using ProjetoDDDSimplificado.Domain.Entidades.Base;
using ProjetoDDDSimplificado.Domain.Repositories;
using ProjetoDDDSimplificado.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDDSimplificado.Services.Services.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IEntity
    {
        private readonly IRepository<TEntity> _repository;

        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Create(TEntity entity)
        {
            _repository.Create(entity);
        }

        public void CreateOrUpdate(TEntity entity)
        {
            _repository.CreateOrUpdate(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IList<TEntity> GetAll()
        {
            return _repository
                .GetAll()
                .ToList();
        }

        public TEntity GetByCodigo(int codigo)
        {
            return _repository.GetByCodigo(codigo);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
