using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.BLL.Interfaces
{
    public interface IBaseService<T>
    {
        Result Add(T item);
        Result Update(int id, T newItem);
        Result Remove(int id);

        Result<T> FindById(int id);
        Result<List<T>> List();
    }
}
