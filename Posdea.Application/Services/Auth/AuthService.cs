using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Common.Exceptions;
using Posdea.Application.Helpers.Auth;
using Posdea.Application.Models.Auth;
using Posdea.Application.Models.UserSegment;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posdea.Application.Common.Interfaces.Helpers;

namespace Posdea.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IPasswordHelper passwordHelper;
        private readonly ITokenHelper tokenHelper;

        public AuthService(IApplicationDbContext dbContext, IMapper mapper, IPasswordHelper passwordHelper, ITokenHelper tokenHelper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.passwordHelper = passwordHelper;
            this.tokenHelper = tokenHelper;
        }

        public async Task<object> Login(UserRegisterModel user)
        {
            try
            {
                var dbUser = await dbContext.Users
                    .Where(u => u.Email == user.Email)
                    .Include(u => u.Role)
                    .Include(u => u.Address)
                    .FirstOrDefaultAsync();

                if (dbUser == null)
                {
                    throw new NotFoundException($"The user with the email {user.Email} was not found");
                }
                if (!passwordHelper.VerifyPasswordHash(user.Password, dbUser.PasswordHash, dbUser.PasswordSalt))
                {
                    throw new ValidationException("Wrong password");
                }

                var userModel = mapper.Map<UserModel>(dbUser);

                //token creation
                var token = tokenHelper.CreateToken(dbUser);

                return new { User = userModel, Token = token};
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserModel> SignUp(UserModel user)
        {
            try
            {
                var dbUser = await dbContext.Users
                    .Where(u => u.Email == user.Email)
                    .FirstOrDefaultAsync();

                if(dbUser != null)
                {
                    throw new ValidationException($"The user with the email {user.Email} already exists");
                }

                var userMap = mapper.Map<User>(user);
                userMap.PasswordSalt = passwordHelper.GetPasswordSalt();
                userMap.PasswordHash = passwordHelper.GetPasswordHash(user.Password);
                userMap.RoleId = user.RoleId;
                userMap.Status = Domain.Enums.UserStatus.active;
                dbContext.Users.Add(userMap);
                await dbContext.SaveChangesAsync();
                return mapper.Map<UserModel>(userMap);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}