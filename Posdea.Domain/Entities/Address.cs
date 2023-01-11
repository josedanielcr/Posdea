using Posdea.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Domain.Entities.UserSegment
{
    public class Address : BaseAuditableEntity
    {
        [Required]
        public int Country { get; set; }
    }
}
