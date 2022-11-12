using Posdea.Application.Common.Interfaces;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services
{
    public class RoleService : ICrudService<Role>
    {
        private readonly IApplicationDbContext dbContext;

        public RoleService(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Role> Insert(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<Role> Update(int id, Role newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
