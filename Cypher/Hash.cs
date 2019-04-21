using System;
using System.Text;
using System.Security.Cryptography;
using static Cypher.Constants;

namespace Cypher
{
    public static class Hash
    {
        /// <summary>
        /// Creates MD5 hash (128 bit - 16 byte)
        /// </summary>
        /// <param name="input">The string we want to hash</param>
        /// <returns>MD5 hashcode</returns>
        public static string MD5_Hash(string input)
        {
            return CreateHash(MD5.Create(), input);
        }

        /// <summary>
        /// Creates SHA-1 hash (160 bit - 20 byte)
        /// </summary>
        /// <param name="input">The string we want to hash</param>
        /// <returns>SHA-1 hashcode</returns>
        public static string SHA1_Hash(string input)
        {
            return CreateHash(new SHA1CryptoServiceProvider(), input);
        }

        /// <summary>
        /// Creates SHA-2 hash (512 bit - 64 byte)
        /// </summary>
        /// <param name="input">The string we want to hash</param>
        /// <returns>SHA-2 hashcode</returns>
        public static string SHA2_Hash(string input)
        {
            return CreateHash(new SHA512Managed(), input);
        }

        public static string CreateHash(HashAlgorithm hashAlgorithm, string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), ParameterIsNull);
            }
            var sb = new StringBuilder();
            var hashBytes = hashAlgorithm.ComputeHash(Encoding.Default.GetBytes(input));
            foreach (var hashByte in hashBytes)
            {
                sb.Append(hashByte.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
