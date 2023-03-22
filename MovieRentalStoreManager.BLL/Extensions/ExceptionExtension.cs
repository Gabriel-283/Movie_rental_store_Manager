using FluentResults;
using Microsoft.AspNetCore.Mvc;
using MovieRentalStoreManager.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.BLL.Extensions
{
    public static class ExceptionExtension
    {
        public static Result GetNotFoundError(string errorMessage = "objeto não encontrado")
        {
            return Result.Fail(new NotFoundException(errorMessage));
        }

        public static Result GetBadRequestError(string errorMessage = "Favor validar request")
        {
            return Result.Fail(new BadRequestException(errorMessage));
        }
    }
}
