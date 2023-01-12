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
    public class User : BaseAuditableEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string avatar { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public UserStatus Status { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required]
        public Role Role { get; set; }
        [Required]
        public int RoleId { get; set; }
    }
}