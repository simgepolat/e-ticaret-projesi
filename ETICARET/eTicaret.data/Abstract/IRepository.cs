using System.Collections.Generic;

namespace eTicaret.data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}