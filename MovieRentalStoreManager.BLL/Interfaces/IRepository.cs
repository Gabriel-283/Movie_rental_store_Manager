using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.BLL.Interfaces
{
    public interface IRepository<T>
    {
        Result Add(T entity);
        Result<T> GetById(int id);
        Result<List<T>> List();
        void Update(int id, T entity);
        Result<int> Remove(int id);
    }
}
