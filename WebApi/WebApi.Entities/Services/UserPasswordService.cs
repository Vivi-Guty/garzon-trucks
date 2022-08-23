using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public class UserPasswordService
    {
        //private readonly System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();

        public byte[] GetSalt()
        {
            //byte[] salt = new byte[16];
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            //rng.GetBytes(salt);
            return salt;
        }

        public byte[] GetHash(string password, byte[] salt)
        {
            var rfc = new Rfc2898DeriveBytes(password, salt);
            return rfc.GetBytes(32);
        }

        public bool IsValidPassword(string password, byte[] salt, byte[] hash)
        {
            var passwordHash = GetHash(password, salt);
            return passwordHash.SequenceEqual(hash);
        }
    }
}
