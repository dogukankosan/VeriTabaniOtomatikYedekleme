﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace AsyenOtomatikYedekleme.Classes
{
    internal class EncryptionHelper
    {
        internal static string Encrypt(string plainText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
            byte[] ivBytes = Encoding.UTF8.GetBytes("1234567890123456");
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyBytes;
                aesAlg.IV = ivBytes;
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
        internal static string Decrypt(string cipherText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
            byte[] ivBytes = Encoding.UTF8.GetBytes("1234567890123456");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyBytes;
                aesAlg.IV = ivBytes;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
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