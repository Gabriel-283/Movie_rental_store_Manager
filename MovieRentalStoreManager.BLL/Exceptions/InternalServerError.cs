using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.BLL.Exceptions
{
    public class InternalServerError : Error
    {
        public InternalServerError(string message) : base(message) { }
    }
}
