using Posdea.Application.Common.Interfaces;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services
{
    public class AddressService : ICrudService<Address>
    {
        private readonly IApplicationDbContext dbContext;

        public AddressService(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Address> Insert(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<Address> Update(int id, Address newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
