using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Helpers;
using Posdea.Application.Helpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Api.Controllers
{
    [AllowAnonymous]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        private readonly IErrorHelper errorHelper;

        public ErrorController(IErrorHelper errorHelper)
        {
            this.errorHelper = errorHelper;
        }

        [Route("error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context?.Error;;
            return Problem(title: exception?.Message, statusCode: errorHelper.GetExceptionStatusCode(exception));
        }
    }
}