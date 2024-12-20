/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using System.Security.Cryptography;
using System.Text;

namespace YPHF.Core
{
    /// <summary>
    /// Class RSAHelper.
    /// </summary>
    public static class RSAHelper
    {
        /// <summary>
        /// Decrypts the RSA.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public static string DecryptRSA(this string str, string key) => str.DecryptRSA(key, Encoding.Default);

        /// <summary>
        /// Decrypts the RSA.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="key">The key.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>System.String.</returns>
        public static string DecryptRSA(this string str, string key, Encoding encoding)
        {
            var strBuffer = str.DecryptBase64();
            var keyBuffer = key.DecryptBase64();
            var provider = new RSACryptoServiceProvider();
            provider.ImportCspBlob(keyBuffer);
            var result = provider.Decrypt(strBuffer, false);

            return result.ByteToString(encoding);
        }

        /// <summary>
        /// Encrypts the RSA.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public static string EncryptRSA(this string str, out string key) => str.EncryptRSA(out key, Encoding.Default);

        /// <summary>
        /// Encrypts the RSA.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="key">The key.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>System.String.</returns>
        public static string EncryptRSA(this string str, out string key, Encoding encoding)
        {
            var buffer = str.StringToByte(encoding);
            var provider = new RSACryptoServiceProvider();
            var result = provider.Encrypt(buffer, false);
            key = provider.ExportCspBlob(true).EncryptBase64();

            return result.EncryptBase64();
        }
    }
}