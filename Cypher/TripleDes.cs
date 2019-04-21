using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static Cypher.Constants;

namespace Cypher
{
    public static class TripleDes
    {
        public static byte[] TripleDesEncrypt(char[] originalData, byte[] key192Bit,
            byte[] initializationVector64Bit)
        {
            if (key192Bit == null)
            {
                throw new ArgumentNullException(nameof(key192Bit), ParameterIsNull);
            }
            if (initializationVector64Bit == null)
            {
                throw new ArgumentNullException(nameof(initializationVector64Bit), ParameterIsNull);
            }
            if ((key192Bit.Length != 16) && (key192Bit.Length != 24))
            {
                throw new ArgumentException(KeySizeMustBe16Or24Bytes, nameof(key192Bit));
            }
            if ((initializationVector64Bit.Length != 8) && (initializationVector64Bit.Length != 16))
            {
                throw new ArgumentException(InitializationVectorSizeMustBe8Or16Bytes, nameof(initializationVector64Bit));
            }

            var cryptoServiceProvider = new TripleDESCryptoServiceProvider();
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream,
                cryptoServiceProvider.CreateEncryptor(key192Bit, initializationVector64Bit),
                CryptoStreamMode.Write);
            var streamWriter = new StreamWriter(cryptoStream);

            streamWriter.Write(originalData);
            streamWriter.Flush();
            cryptoStream.FlushFinalBlock();
            streamWriter.Close();
            cryptoStream.Close();
            var buffer = memoryStream.ToArray();
            memoryStream.Close();
            return buffer;
        }

        public static string TripleDesEncryptToByteArrayString(string plainText, string password,
            string initializationVector)
        {
            if (plainText == null)
            {
                throw new ArgumentNullException(nameof(plainText), ParameterIsNull);
            }
            var encryptedData = new StringBuilder();
            var encryptedBytes = TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(plainText)),
                Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(initializationVector));
            foreach (var encryptedByte in encryptedBytes)
            {
                encryptedData.AppendFormat("[{0}]", encryptedByte);
            }
            return encryptedData.ToString();
        }

        public static string TripleDES_DecryptFromByteArrayString(string encryptedByteArrayString, string password,
            string initializationVector)
        {
            var byteStrings = encryptedByteArrayString.Split('[', ']');
            var bytes = new byte[byteStrings.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(byteStrings[2 * i + 1]);
            }

            var decrypted = TripleDesDecrypt(bytes, Encoding.ASCII.GetBytes(password),
                Encoding.ASCII.GetBytes(initializationVector));
            return Encoding.UTF8.GetString(decrypted);
        }

        public static string TripleDesEncrypt(string plainText, byte[] password, byte[] iv)
        {
            return
                Base64.Encode(
                    TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(plainText)),
                        password, iv));
        }

        public static string TripleDesEncrypt(string plainText, string password, string iv)
        {
            return
                Base64.Encode(
                    TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(plainText)),
                        Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(iv)));
        }

        public static string TripleDesDecrypt(string cryptedText, byte[] password, byte[] iv)
        {
            return
                Encoding.UTF8.GetString(TripleDesDecrypt(Base64.DecodeToArray(cryptedText), password, iv));
        }

        public static string TripleDesDecrypt(string cryptedText, string password, string iv)
        {
            return
                Encoding.UTF8.GetString(TripleDesDecrypt(Base64.DecodeToArray(cryptedText),
                    Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(iv)));
        }

        public static byte[] TripleDesDecrypt(byte[] cryptedData, byte[] key192Bit,
            byte[] initializationVector64Bit)
        {
            if (cryptedData == null)
            {
                return null;
            }
            if (key192Bit == null)
            {
                throw new ArgumentNullException("key_192_bit", ParameterIsNull);
            }
            if (initializationVector64Bit == null)
            {
                throw new ArgumentNullException("initialization_vector_64_bit", ParameterIsNull);
            }
            if ((key192Bit.Length != 16) && (key192Bit.Length != 24))
            {
                throw new ArgumentException(KeySizeMustBe16Or24Bytes, nameof(key192Bit));
            }
            if ((initializationVector64Bit.Length != 8) && (initializationVector64Bit.Length != 16))
            {
                throw new ArgumentException(InitializationVectorSizeMustBe8Or16Bytes, nameof(initializationVector64Bit));
            }

            var cryptoServiceProvider = new TripleDESCryptoServiceProvider();
            if (cryptedData.Length == 0) return new byte[0];
            var memoryStream = new MemoryStream(cryptedData);
            var cryptoStream = new CryptoStream(memoryStream,
                cryptoServiceProvider.CreateDecryptor(key192Bit, initializationVector64Bit),
                CryptoStreamMode.Read);
            var streamReader = new StreamReader(cryptoStream, Encoding.UTF8);

            var result = Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
            return result;
        }

        public static string DecryptByteArrayArguments(string encryptedText, string password, string iv)
        {
            var byteStrings = encryptedText.Split('[', ']');
            var bytes = new byte[byteStrings.Length / 2];

            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(byteStrings[2 * i + 1]);
            }

            var decrypted = TripleDesDecrypt(bytes, Encoding.ASCII.GetBytes(password),
                Encoding.ASCII.GetBytes(iv));
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
