using Microsoft.EntityFrameworkCore;
using Posdea.Domain.Entities;
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
    }
}
