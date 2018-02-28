using ProjetoDDDSimplificado.Domain.Entidades.Base;
using System;
using System.Collections.Generic;


namespace ProjetoDDDSimplificado.Services.Interface.Base
{
    public interface IBaseService<TEntity> where TEntity : IEntity
    {
        IList<TEntity> GetAll();
        TEntity GetByCodigo(int codigo);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void CreateOrUpdate(TEntity entity);
        void Delete(TEntity entity);
    }
}
