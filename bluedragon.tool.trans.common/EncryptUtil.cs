using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.common
{
    /// <summary>
    /// 说明：BitConvert 将字节数组转换为XX-XX-XX的形式
    ///       与Convert.ToBase64String区分
    /// </summary>
    public class EncryptUtil
    {
        #region 加密
        public static string Encrypt(EncryptType type, string sourceString)
        {
            switch (type)
            {
                case EncryptType.MD5:
                    return MD5Encrypt(sourceString);
                case EncryptType.RSA:
                    return RSAEncrypt(sourceString);
                case EncryptType.BASE64:
                    return BASE64Encrypt(sourceString);
                case EncryptType.SHA1:
                    return SHA1Encrypt(sourceString);
                default:
                    return "加密算法未实现";
            }
        }

        public static string Encrypt(EncryptType type, string sourceString, string key, string iv)
        {
            switch (type)
            {
                case EncryptType.DES:
                    return DESEncrypt(sourceString, key, iv);
                case EncryptType.AES:
                    return AESEncrypt(sourceString, key, iv);
                default:
                    return "加密方式不正确";
            }
        }

        private static string SHA1Encrypt(string sourceString)
        {
            throw new NotImplementedException();
        }

        private static string BASE64Encrypt(string sourceString)
        {
            throw new NotImplementedException();
        }

        private static string RSAEncrypt(string sourceString)
        {
            RSA rsa = RSA.Create();
            throw new NotImplementedException();
        }

        /// <summary>
        /// 要求：key 32位 iv 16位
        /// </summary>
        /// <param name="sourceString"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private static string AESEncrypt(string sourceString, string key, string iv)
        {
            Rijndael aes = Rijndael.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);
            byte[] sourceBytes = Encoding.UTF8.GetBytes(sourceString);
            byte[] encryptBytes = aes.CreateEncryptor().TransformFinalBlock(sourceBytes, 0, sourceBytes.Length);
            return BitConverter.ToString(encryptBytes);
        }

        /// <summary>
        /// 要求：key&iv至少8位
        /// </summary>
        /// <param name="sourceString"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private static string DESEncrypt(string sourceString, string key, string iv)
        {
            #region 方式1
            //byte[] byteKey = Encoding.UTF8.GetBytes(key);
            //byte[] byteIv = Encoding.UTF8.GetBytes(iv);

            //DES des = DES.Create();
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    byte[] byteSource = Encoding.UTF8.GetBytes(sourceString);
            //    using (CryptoStream cs = new CryptoStream(ms,
            //        des.CreateEncryptor(byteKey, byteIv), CryptoStreamMode.Write))
            //    {
            //        cs.Write(byteSource, 0, byteSource.Length);

            //        cs.FlushFinalBlock();
            //    }

            //    return Convert.ToBase64String(ms.ToArray());
            //}
            #endregion

            byte[] byteKey = Encoding.UTF8.GetBytes(key);
            byte[] byteIv = Encoding.UTF8.GetBytes(iv);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = byteKey;
            des.IV = byteIv;
            ICryptoTransform cryptoTransform = des.CreateEncryptor();
            byte[] byteSource = Encoding.UTF8.GetBytes(sourceString);
            byte[] byteEncrypt = cryptoTransform.TransformFinalBlock(byteSource, 0, byteSource.Length);
            return BitConverter.ToString(byteEncrypt);
        }

        private static string MD5Encrypt(string sourceString)
        {
            #region
            //byte[] bytes = Encoding.UTF8.GetBytes(sourceString);
            //MD5 md5 = MD5.Create();
            //byte[] hashBytes = md5.ComputeHash(bytes);
            //StringBuilder sb = new StringBuilder();
            //foreach (byte hashByte in hashBytes)
            //{
            //    sb.Append(hashByte.ToString("X2"));
            //}
            //return sb.ToString();
            #endregion
            byte[] bytes = Encoding.UTF8.GetBytes(sourceString);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
        #endregion
        public static string Decrypt(EncryptType type)
        {
            return string.Empty;
        }

        public static string Decrypt(EncryptType type, string sourceString, string key, string iv)
        {
            switch (type)
            {
                case EncryptType.DES:
                    return DESDecrypt(sourceString, key, iv);
                case EncryptType.AES:
                    return AESDecrypt(sourceString, key, iv);
                default:
                    return "解密算法未实现";
            }
        }

        private static string AESDecrypt(string sourceString, string key, string iv)
        {
            Rijndael aes = Rijndael.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);
            #region BitConvert.ToString()的逆过程
            string[] sourceArr = sourceString.Split('-');
            byte[] sourceBytes = new byte[sourceArr.Length];
            for (int i = 0; i < sourceArr.Length; i++)
                sourceBytes[i] = byte.Parse(sourceArr[i], NumberStyles.HexNumber);
            #endregion
            byte[] encryptBytes = aes.CreateDecryptor().TransformFinalBlock(sourceBytes, 0, sourceBytes.Length);
            return Encoding.UTF8.GetString(encryptBytes);
        }

        private static string DESDecrypt(string sourceString, string key, string iv)
        {
            byte[] byteKey = Encoding.UTF8.GetBytes(key);
            byte[] byteIv = Encoding.UTF8.GetBytes(iv);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = byteKey;
            des.IV = byteIv;
            ICryptoTransform cryptoTransform = des.CreateDecryptor();
            #region BitConvert.ToString()的逆过程
            string[] sourceArr = sourceString.Split('-');
            byte[] sourceBytes = new byte[sourceArr.Length];
            for (int i = 0; i < sourceArr.Length; i++)
                sourceBytes[i] = byte.Parse(sourceArr[i], NumberStyles.HexNumber);
            #endregion
            byte[] byteDecrypt = cryptoTransform.TransformFinalBlock(sourceBytes, 0, sourceBytes.Length);
            return Encoding.UTF8.GetString(byteDecrypt);
        }
    }

    public enum EncryptType
    {
        MD5,
        DES,
        AES,
        RSA,
        BASE64,
        SHA1
    }
}
