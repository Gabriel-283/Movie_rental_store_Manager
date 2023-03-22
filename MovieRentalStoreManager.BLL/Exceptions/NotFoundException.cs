using FluentResults;

namespace MovieRentalStoreManager.BLL.Exceptions
{
    public class NotFoundException : Error
    {
        public NotFoundException(string message) : base(message) { }
    }
}
