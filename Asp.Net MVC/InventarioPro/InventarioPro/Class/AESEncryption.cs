using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace InventarioPro.Class
{
    public class AESEncryption
    {

        private static readonly int KeySize     = 256; // Tamaño de clave en bits (128, 192, o 256)
        private static readonly int BlockSize   = 128; // Tamaño de bloque en bits

        public static string Encrypt(string plainText, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize      = KeySize;
                aesAlg.BlockSize    = BlockSize;
                aesAlg.Key          = Encoding.UTF8.GetBytes(key);
                aesAlg.IV           = Encoding.UTF8.GetBytes(iv);
                aesAlg.Mode         = CipherMode.CFB; // Modo de cifrado

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize      = KeySize;
                aesAlg.BlockSize    = BlockSize;
                aesAlg.Key          = Encoding.UTF8.GetBytes(key);
                aesAlg.IV           = Encoding.UTF8.GetBytes(iv);
                aesAlg.Mode         = CipherMode.CFB; // Modo de cifrado

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}