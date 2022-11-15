using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services
{
    public interface IAuthService
    {
        Task<UserModel> SignUp(UserModel user);
    }
}