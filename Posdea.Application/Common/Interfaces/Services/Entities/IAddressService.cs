using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Common.Interfaces.Services.Entities
{
    public interface IAddressService
    {
        Task<AddressModel> GetById(int id);
    }
}
