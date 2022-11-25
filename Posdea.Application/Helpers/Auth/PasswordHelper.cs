using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Posdea.Application.Common.Interfaces.Helpers;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Helpers.Auth
{
    public class PasswordHelper : IPasswordHelper
    {
        private HMACSHA512 hmac { get; set; }

        public PasswordHelper()
        {
            this.hmac = new HMACSHA512();
        }

        public byte[] GetPasswordHash(string password)
        {
            return hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public byte[] GetPasswordSalt()
        {
            return hmac.Key;
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                byte[] salt = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return salt.SequenceEqual(passwordHash);
            }
        }
    }
}