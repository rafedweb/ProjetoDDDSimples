using ProjetoDDDSimplificado.Domain.Entidades.Base;
using System.Linq;


namespace ProjetoDDDSimplificado.Domain.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> Get();
        IQueryable<T> GetAll();
        T GetByCodigo(int Codigo);
        void Create(T entity);
        void Update(T entity);
        void CreateOrUpdate(T entity);
        void Delete(T entity);
    }
}
