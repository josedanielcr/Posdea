using Posdea.Domain.Common;
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
        public string Name { get; set; }
    }
}
