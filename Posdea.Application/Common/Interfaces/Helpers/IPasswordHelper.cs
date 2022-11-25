using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Helpers
{
    public interface IPasswordHelper
    {
        byte[] GetPasswordHash(string password);
        byte[] GetPasswordSalt();
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
    }
}
