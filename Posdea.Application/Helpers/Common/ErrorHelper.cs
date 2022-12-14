using Posdea.Application.Common.Exceptions;
using Posdea.Application.Common.Interfaces.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Helpers.Common
{
    public class ErrorHelper : IErrorHelper
    {
        public int GetExceptionStatusCode(Exception e)
        {
            if (e is NotFoundException)
            {
                return (int)HttpStatusCode.NotFound;
            }
            else if (e is ValidationException)
            {
                return (int)HttpStatusCode.BadRequest;
            }
            return (int)HttpStatusCode.InternalServerError;
        }
    }
}