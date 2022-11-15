using AutoMapper;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Helpers.Auth;
using Posdea.Application.Models.UserSegment;
using Posdea.Application.Services.Entities;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private AuthenticationHelper authHelper;

        public AuthService(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            authHelper = new AuthenticationHelper();
        }
        public async Task<UserModel> SignUp(UserModel user)
        {
            try
            {
                var dbUser = mapper.Map<User>(user);
                dbUser.PasswordSalt = authHelper.GetPasswordSalt();
                dbUser.PasswordHash = authHelper.GetPasswordHash(user.Password);
                dbUser.RoleId = user.RoleId;
                dbContext.Users.Add(dbUser);
                await dbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}