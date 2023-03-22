using FluentResults;
using MovieRentalStoreManager.BLL.Entities;

namespace MovieRentalStoreManager.BLL.Interfaces
{
    public interface IRentalService : IBaseService<Rental>
    {
        Result<List<Movie>> ListMovies();
        Result<List<Customer>> ListCustomers();
    }
}
