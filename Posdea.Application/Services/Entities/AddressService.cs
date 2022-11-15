using Posdea.Application.Common.Interfaces;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services.Entities
{
    public class AddressService : ICrudService<AddressModel>, IAddressService
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

        public Task<IEnumerable<AddressModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AddressModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AddressModel> Insert(AddressModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<AddressModel> Update(int id, AddressModel newEntity)
        {
            throw new NotImplementedException();
        }
    }
}