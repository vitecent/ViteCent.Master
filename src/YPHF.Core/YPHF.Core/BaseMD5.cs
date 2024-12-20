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
    /// Class MD5Helper.
    /// </summary>
    public static class MD5Helper
    {
        /// <summary>
        /// Encrypts the m d5.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.String.</returns>
        public static string EncryptMD5(this string str) => str.EncryptMD5(Encoding.Default);

        /// <summary>
        /// Encrypts the m d5.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>System.String.</returns>
        public static string EncryptMD5(this string str, Encoding encoding)
        {
            var buffer = str.StringToByte(encoding);
            var provider = MD5.Create();
            var hash = provider.ComputeHash(buffer);

            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}