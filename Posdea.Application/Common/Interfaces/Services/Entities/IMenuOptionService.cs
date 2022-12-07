using Posdea.Application.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services.Entities
{
    public interface IMenuOptionService
    {
        Task<IEnumerable<MenuOptionModel>> GetAll(int roleId);

        Task<MenuOptionModel> Update(MenuOptionModel menuOption, int menuOptionId);
    }
}
