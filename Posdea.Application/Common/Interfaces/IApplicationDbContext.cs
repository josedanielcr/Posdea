using Microsoft.EntityFrameworkCore;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Address> Address { get; }
        DbSet<Role> Roles { get; }

        DbSet<MenuOption> MenuOptions { get; }
        Task<int> SaveChangesAsync();
    }
}
