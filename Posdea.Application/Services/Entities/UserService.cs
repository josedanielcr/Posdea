using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Posdea.Application.Common.Exceptions;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMapper mapper;

        public UserService(IApplicationDbContext dbContext, 
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.httpContextAccessor = httpContextAccessor;
            this.mapper = mapper;
        }

        public Task<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetCurrentUser()
        {
            try
            {
                if (httpContextAccessor.HttpContext.User == null)
                {
                    throw new Exception("Internal server error");
                }

                var EmailClaim = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
                if (EmailClaim == null)
                {
                    throw new NotFoundException("Internal server error, current user not found");
                }

                var User = await dbContext.Users
                    .Where(u => u.Email == EmailClaim)
                    .Where(u => u.Status == Domain.Enums.UserStatus.active)
                    .Include(u => u.Role)
                    .Include(u => u.Address)
                    .FirstOrDefaultAsync();

                if(User== null)
                {
                    throw new NotFoundException("The user with with the email {EmailClaim} was not found");
                }

                return mapper.Map<UserModel>(User);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}