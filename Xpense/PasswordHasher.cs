using CryptSharp.Utility;
using System;
using System.Text;
namespace Xpense
{
    class PasswordHasher
    {

        public static string Password_Hasher(string password)
        {
            //hashes the password
            string salt = "A23S";
            var keyBytes = Encoding.UTF8.GetBytes(password);
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var cost = 262144;
            var blockSize = 8;
            var parallel = 1;
           // var maxThreads = (int?)null;
            var derivedKeyLength = 256;
            var bytes = SCrypt.ComputeDerivedKey(keyBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength);
            return Convert.ToBase64String(bytes);
        }

    }
}
