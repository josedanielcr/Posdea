using Posdea.Domain.Common;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Domain.Entities
{
    public class MenuOption : BaseAuditableEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Route { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public EntityStatus Status { get; set; }
    }
}