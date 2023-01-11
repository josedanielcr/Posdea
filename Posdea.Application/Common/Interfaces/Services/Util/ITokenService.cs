using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services.Util
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
