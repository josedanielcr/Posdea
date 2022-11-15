using AutoMapper;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.UserSegment;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class RoleService : ICrudService<RoleModel>, IRoleService
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public RoleService(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<int> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoleModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<RoleModel> GetById(int id)
        {
            var role = await dbContext.Roles.FindAsync(id);
            return mapper.Map<RoleModel>(role);
        }

        public async Task<RoleModel> Insert(RoleModel entity)
        {
            var role = mapper.Map<Role>(entity); 
            var dbRole = dbContext.Roles.Add(role);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<RoleModel> Update(int id, RoleModel newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
