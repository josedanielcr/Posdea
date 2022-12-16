using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Posdea.Application.Common.Exceptions;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.UserSegment;
using Posdea.Domain.Entities.UserSegment;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class RoleService : IParameterService<RoleModel>, IRoleService
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
            try
            {
                var role = await dbContext.Roles.Where(r => r.Id == id).FirstOrDefaultAsync();
                if(role == null)
                {
                    throw new NotFoundException($"The rol with the id {id} was not found");
                }
                dbContext.Roles.Remove(role);
                await dbContext.SaveChangesAsync();
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<RoleModel>> GetAll()
        {
            try
            {
                var roles = await dbContext.Roles.ToListAsync();

                if(roles.Count == 0)
                {
                    throw new NotFoundException("There are no roles registered");
                }

                List<RoleModel> modelRolesList = new List<RoleModel>();

                foreach (Role role in roles)
                {
                    modelRolesList.Add(mapper.Map<RoleModel>(role));
                }

                return modelRolesList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RoleModel> GetById(int id)
        {
            try
            {
                var role = await dbContext.Roles.Where(r => r.Id == id).FirstOrDefaultAsync();
                if(role == null)
                {
                    throw new NotFoundException($"The rol with the id {id} was not found");
                }
                return mapper.Map<RoleModel>(role);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RoleModel> GetByRoleName(UserRoles role)
        {
            try
            {
                var roleDb = await dbContext.Roles
                    .Where(r => r.Name == role)
                    .FirstOrDefaultAsync();

                if (roleDb == null)
                {
                    throw new NotFoundException("No role was found");
                }
                return mapper.Map<RoleModel>(roleDb);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RoleModel> Insert(RoleModel entity)
        {
            try
            {
                var role = mapper.Map<Role>(entity);
                dbContext.Roles.Add(role);
                await dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public async Task<RoleModel> Update(int id, RoleModel newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
