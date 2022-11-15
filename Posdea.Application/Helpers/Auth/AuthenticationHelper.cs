using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Helpers.Auth
{
    public class AuthenticationHelper
    {
        private HMACSHA512 hmac { get; set; }

        public AuthenticationHelper()
        {
            this.hmac = new HMACSHA512();
        }

        public byte[] GetPasswordHash(string password)
        {
            return hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public byte[] GetPasswordSalt()
        {
            return this.hmac.Key;
        }

    }
}