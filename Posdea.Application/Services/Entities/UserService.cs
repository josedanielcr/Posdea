using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class UserService : ICrudService<UserModel>, IUserService
    {
        private readonly IApplicationDbContext dbContext;

        public UserService(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Insert(UserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Update(int id, UserModel newEntity)
        {
            throw new NotImplementedException();
        }
    }
}