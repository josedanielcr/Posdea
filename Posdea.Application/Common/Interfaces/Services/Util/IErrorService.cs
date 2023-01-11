using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Helpers
{
    public interface IErrorService
    {
        int GetExceptionStatusCode(Exception e);
    }
}
