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
    public class UserModel : IMapFrom<User>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public string Status { get; set; }
        [Required]
        public AddressModel Address { get; set; }
        public int? AddressId { get; set; }
        public RoleModel? Role { get; set; }
        public int RoleId { get; set; }
    }
}