using Posdea.Application.Common.Interfaces;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services
{
    public class UserService : ICrudService<User>
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

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(int id, User newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
