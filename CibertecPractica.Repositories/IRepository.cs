using System;
using System.Collections.Generic;
using System.Text;

namespace CibertecPractica.Repositories
{
    public interface IRepository<T>
    {
        bool Delete(T entity);
        bool Update(T entity);
        int Insert(T entity);
        IEnumerable<T> GetList();
        T GetById(int Id);
    }
}
