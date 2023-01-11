using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Posdea.Application.Common.Exceptions;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.Entities;
using Posdea.Application.Models.UserSegment;
using Posdea.Domain.Entities;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class MenuOptionService : IMenuOptionService
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public MenuOptionService(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<MenuOptionModel> Update(MenuOptionModel menuOption, int MenuOptionId)
        {
            try
            {
                var menuOptionDb = await dbContext.MenuOptions
                    .Where(m => m.Id == menuOption.Id)
                    .Where(m => m.Status == EntityStatus.Active)
                    .FirstOrDefaultAsync();

                if (menuOptionDb == null)
                {
                    throw new NotFoundException("Menu option not found");
                }

                if(menuOption == null)
                {
                    throw new ValidationException("The new option is null");
                }

                var menuOptionDbModel = mapper.Map<MenuOption>(menuOption);
                dbContext.MenuOptions.Update(menuOptionDbModel);
                await dbContext.SaveChangesAsync();
                return menuOption;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public async Task<IEnumerable<MenuOptionModel>> GetAll(int RoleId)
        {
            try
            {
                var menuOptions = await dbContext.MenuOptions
                    .Where(m => m.RoleId == RoleId)
                    .Where(m => m.Status == EntityStatus.Active)
                    .ToListAsync();

                if (menuOptions.Count == 0)
                {
                    throw new NotFoundException("There are no menu options for this role");
                }

                List<MenuOptionModel> menuOptionList = new List<MenuOptionModel>();

                foreach (MenuOption menuOption in menuOptions)
                {
                    menuOptionList.Add(mapper.Map<MenuOptionModel>(menuOption));
                }

                return menuOptionList;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}