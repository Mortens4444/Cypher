using System;
using System.Text;

namespace Cypher
{
    public static class SimpleCypher
    {
        public static string XorCypher(string source, string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password should not be empty.");
            }

            int i = 0, j = 0;
            var result = new StringBuilder();

            while (i < source.Length)
            {
                var appendChar = source[i] != password[j] ? (char)(source[i] ^ password[j]) : source[i];
                result.Append(appendChar);
                i++;
                j++;
                if (j >= password.Length)
                {
                    j = 0;
                }
            }

            return result.ToString();
        }

        public static byte[] XorCypher(byte[] source, byte[] password)
        {
            if ((password == null) || (password.Length == 0))
            {
                throw new ArgumentException("Password should not be empty.");
            }

            var result = new byte[source.Length];
            int i = 0, j = 0;

            while (i < source.Length)
            {
                result[i] = (byte) (source[i] ^ password[j]);
                i++;
                j++;
                if (j >= password.Length)
                {
                    j = 0;
                }
            }

            return result;
        }

        public static string RotateCypher(string source, int rotateKey)
        {
            int i = 0, j = 0;
            var result = new StringBuilder(source);

            while (rotateKey > source.Length)
            {
                rotateKey -= source.Length;
            }
            while (rotateKey < -source.Length)
            {
                rotateKey += source.Length;
            }

            if (rotateKey > 0) // rotate right
            {
                j = rotateKey;
                while (i < source.Length)
                {
                    while (j >= source.Length)
                    {
                        j -= source.Length;
                    }
                    result[j] = source[i];
                    i++;
                    j++;
                }
            }
            else if (rotateKey < 0) // rotate left
            {
                i += -rotateKey;
                while (j < source.Length)
                {
                    while (i >= source.Length)
                    {
                        i -= source.Length;
                    }
                    result[j] = source[i];
                    i++;
                    j++;
                }
            }

            return result.ToString();
        }

        public static string ReplaceCypher(string source, int replaceKey)
        {
            var result = new StringBuilder(source);

            for (var i = 0; i < result.Length; i++)
            {
                var newChar = (char)(source[i] + replaceKey);
                result[i] = newChar != 0 ? newChar : source[i];
            }

            return result.ToString();
        }

        public static byte[] ReplaceCypher(byte[] source, int replaceKey)
        {
            var result = new byte[source.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (byte)(source[i] + replaceKey);
            }

            return result;
        }
    }
}
