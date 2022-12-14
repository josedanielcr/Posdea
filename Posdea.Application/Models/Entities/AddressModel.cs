using AutoMapper;
using Posdea.Application.Mappings;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Models.UserSegment
{
    public class AddressModel : IMapFrom<Address>
    {
        public int Id { get; set; }
        [Required]
        public int Country { get; set; }
        [Required]
        public int State { get; set; }
        [Required]
        public int City { get; set; }
        [Required]
        public int PostalCode { get; set; }

    }
}
