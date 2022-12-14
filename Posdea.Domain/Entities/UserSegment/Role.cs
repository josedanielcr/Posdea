using Posdea.Domain.Common;
using Posdea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Domain.Entities.UserSegment
{
    public class Role : BaseAuditableEntity
    {
        [Required]
        public UserRoles Name { get; set; }
        public IEnumerable<MenuOption>? MenuOptions { get; set; }
    }
}