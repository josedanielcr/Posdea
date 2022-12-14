using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services.Entities
{
    public interface IRoleService
    {
        Task<RoleModel> GetById(int id);
    }
}
