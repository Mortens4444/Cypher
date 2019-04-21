using System;
using System.Text;

namespace Cypher
{
    public static class StringExtensions
    {
        /// <summary>
        /// Creates a byte array from a string if it's in the correct format. Ex: [12][243][124][68]
        /// </summary>
        /// <param name="value">String representation of the byte array. Ex: [12][243][124][68]</param>
        /// <returns>A byte array. Ex: new byte[] { 12, 243, 124, 68 };</returns>
        public static byte[] StringToByteArray(this string value)
        {
            var byteStrings = value.Split('[', ']');
            var bytes = new byte[byteStrings.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(byteStrings[2 * i + 1]);
            }
            return bytes;
        }


        public static string RotateEncrypt(this string value, int key)
        {
            return SimpleCypher.RotateCypher(value, key);
        }

        public static string RotateDecrypt(this string value, int key)
        {
            return SimpleCypher.RotateCypher(value, -key);
        }

        public static string Md5(this string value)
        {
            return Hash.MD5_Hash(value);
        }

        public static string Sha1(this string value)
        {
            return Hash.SHA1_Hash(value);
        }

        public static string Sha2(this string value)
        {
            return Hash.SHA2_Hash(value);
        }

        public static string Base64Encode(this string value)
        {
            return Base64.Encode(value);
        }

        public static string Base64Decode(this string value)
        {
            return Base64.Decode(value);
        }

        public static string XorCrypt(this string value, string password)
        {
            return SimpleCypher.XorCypher(value, password);
        }

        public static string CaesarEncrypt(this string value, int key)
        {
            return SimpleCypher.ReplaceCypher(value, key);
        }

        public static string CaesarDecrypt(this string value, int key)
        {
            return SimpleCypher.ReplaceCypher(value, -key);
        }

        public static string DesEncrypt(this string value, string password)
        {
            var passBytes = Encoding.ASCII.GetBytes(password);
            return
                Base64.Encode(Des.DesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(value)), passBytes,
                    passBytes));
        }

        public static string DesDecrypt(this string value, string password)
        {
            var passBytes = Encoding.ASCII.GetBytes(password);
            return Encoding.UTF8.GetString(Des.DesDecrypt(Base64.DecodeToArray(value), passBytes, passBytes));
        }

        public static string DesEncrypt(this string value, string password, string iv)
        {
            return
                Base64.Encode(Des.DesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(value)),
                    Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(iv)));
        }

        public static string DesDecrypt(this string value, string password, string iv)
        {
            return
                Encoding.UTF8.GetString(Des.DesDecrypt(Base64.DecodeToArray(value), Encoding.ASCII.GetBytes(password),
                    Encoding.ASCII.GetBytes(iv)));
        }

        public static string TripleDesEncrypt(this string value, string password)
        {
            var passBytes = Encoding.ASCII.GetBytes(password);
            return
                Base64.Encode(TripleDes.TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(value)),
                    passBytes, passBytes));
        }

        public static string TripleDesDecrypt(this string value, string password)
        {
            var passBytes = Encoding.ASCII.GetBytes(password);
            return
                Encoding.UTF8.GetString(TripleDes.TripleDesDecrypt(Base64.DecodeToArray(value), passBytes, passBytes));
        }

        public static string TripleDesDecrypt(this string value, byte[] password, byte[] iv)
        {
            return TripleDes.TripleDesDecrypt(value, password, iv);
        }

        public static string TripleDesDecrypt(this string value, string password, string iv)
        {
            return Encoding.UTF8.GetString(TripleDes.TripleDesDecrypt(Base64.DecodeToArray(value), Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(iv)));
        }

        public static string TripleDesEncrypt(this string value, string password, string iv)
        {
            return
                Base64.Encode(TripleDes.TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(value)),
                    Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(iv)));
        }

        public static string TripleDesEncrypt(this string value, byte[] password, byte[] iv)
        {
            return TripleDes.TripleDesEncrypt(value, password, iv);
        }

        public static string TripleDesEncryptToArray(this string value, string password, string iv)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            var encrypted = TripleDes.TripleDesEncrypt(Encoding.UTF8.GetChars(bytes), Encoding.ASCII.GetBytes(password),
                Encoding.ASCII.GetBytes(iv));
            return encrypted.ToArrayString();
        }

        public static string Reverse(this string value)
        {
            var reverse = new StringBuilder();
            for (var i = value.Length - 1; i >= 0; i--)
            {
                reverse.Append(value[i]);
            }
            return reverse.ToString();
        }
    }
}