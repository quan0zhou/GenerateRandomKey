using System;
using System.Security.Cryptography;
using System.Text;

namespace GenerateRandomKey
{
    class Program
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("For SHA1, set the validationKey to 64 bytes (128 hexadecimal characters)");
            Console.WriteLine("For AES, set the decryptionKey to 32 bytes(64 hexadecimal characters)");
            Console.WriteLine("For 3DES, set the decryptionKey to 24 bytes(48 hexadecimal characters)");
            Console.WriteLine("--------------------------------*****************************************-------------------------------------");
            Console.WriteLine($"SHA1-validationKey:{GenerateKey(128)}");
            Console.WriteLine($"AES-decryptionKey:{GenerateKey(64)}");
            Console.WriteLine($"3DES-validationKey:{GenerateKey(48)}");
        }


        private static string GenerateKey(int len) 
        {
            byte[] buff = new byte[len / 2];
            RNGCryptoServiceProvider rng = new
                                    RNGCryptoServiceProvider();
            rng.GetBytes(buff);
            StringBuilder sb = new StringBuilder(len);
            for (int i = 0; i < buff.Length; i++)
                sb.Append(string.Format("{0:X2}", buff[i]));
            return sb.ToString();

        }
    }
}
