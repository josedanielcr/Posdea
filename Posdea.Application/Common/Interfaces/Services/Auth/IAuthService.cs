using Posdea.Application.Models.Auth;
using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services.Auth
{
    public interface IAuthService
    {
        Task<UserModel> SignUp(UserModel user);
        Task<object> Login(UserRegisterModel user);
    }
}