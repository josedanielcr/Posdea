using AutoMapper;
using Posdea.Application.Mappings;
using Posdea.Domain.Entities.UserSegment;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Models.UserSegment
{
    public class RoleModel : IMapFrom<Role>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
