using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Posdea.Application.Common.Interfaces;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){ }

    }
}
