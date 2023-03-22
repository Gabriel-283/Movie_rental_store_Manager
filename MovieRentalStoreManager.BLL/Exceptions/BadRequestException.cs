using FluentResults;

namespace MovieRentalStoreManager.BLL.Exceptions
{
    public class BadRequestException : Error
    {
        public BadRequestException(string message) : base(message) { }
    }
}
