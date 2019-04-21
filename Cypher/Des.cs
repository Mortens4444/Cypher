using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static Cypher.Constants;

namespace Cypher
{
    public static class Des
    {
        public static byte[] DesEncrypt(char[] originalData, byte[] key64Bit, byte[] initializationVector64Bit)
        {
            if (key64Bit == null)
            {
                throw new ArgumentNullException(nameof(key64Bit), ParameterIsNull);
            }
            if (initializationVector64Bit == null)
            {
                throw new ArgumentNullException(nameof(initializationVector64Bit), ParameterIsNull);
            }
            if (key64Bit.Length != 8)
            {
                throw new ArgumentException(KeySizeMustBe8Bytes, nameof(key64Bit));
            }
            if (initializationVector64Bit.Length != 8)
            {
                throw new ArgumentException(InitializationVectorSizeMustBe8Bytes, nameof(initializationVector64Bit));
            }

            var cryptoServiceProvider = new DESCryptoServiceProvider();
            var memoryStream = new MemoryStream();
            var cryptoTransform = cryptoServiceProvider.CreateEncryptor(key64Bit, initializationVector64Bit);
            var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
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

        public static byte[] DesDecrypt(byte[] cryptedData, byte[] key64Bit, byte[] initializationVector64Bit)
        {
            if (cryptedData == null)
            {
                return null;
            }
            if (key64Bit == null)
            {
                throw new ArgumentNullException(nameof(key64Bit), ParameterIsNull);
            }
            if (initializationVector64Bit == null)
            {
                throw new ArgumentNullException(nameof(initializationVector64Bit), ParameterIsNull);
            }

            if (key64Bit.Length != 8)
            {
                throw new ArgumentException(KeySizeMustBe8Bytes, nameof(key64Bit));
            }
            if (initializationVector64Bit.Length != 8)
            {
                throw new ArgumentException(InitializationVectorSizeMustBe8Bytes, nameof(initializationVector64Bit));
            }

            var cryptoServiceProvider = new DESCryptoServiceProvider();
            var memoryStream = new MemoryStream(cryptedData);
            var cryptoTransform = cryptoServiceProvider.CreateDecryptor(key64Bit, initializationVector64Bit);
            var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
            var streamReader = new StreamReader(cryptoStream);

            return Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
        }
    }
}