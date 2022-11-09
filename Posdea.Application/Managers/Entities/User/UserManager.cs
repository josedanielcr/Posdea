using Posdea.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Managers.Entities.User
{
    public class UserManager
    {
        private readonly IApplicationDbContext dbContext;

        public UserManager(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
