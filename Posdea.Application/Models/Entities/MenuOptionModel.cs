using Posdea.Application.Mappings;
using Posdea.Domain.Entities.UserSegment;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Models.Entities
{
    public class MenuOptionModel : IMapFrom<MenuOption>
    {
        public int Id { get; set; }
        [Required]
        public int roleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Route { get; set; }

        public EntityStatus Status { get; set; }
    }
}
