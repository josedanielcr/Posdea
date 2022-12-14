using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Helpers
{
    public interface ITokenHelper
    {
        string CreateToken(User user);
    }
}
