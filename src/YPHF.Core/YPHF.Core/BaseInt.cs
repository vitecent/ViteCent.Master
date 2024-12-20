/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

namespace YPHF.Core
{
    /// <summary>
    /// Class IntHelper.
    /// </summary>
    public static class IntHelper
    {
        /// <summary>
        /// Gets the int.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.Int32.</returns>
        public static int GetInt(this string str) => str.GetInt(default);

        /// <summary>
        /// Gets the int.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Int32.</returns>
        public static int GetInt(this string str, int defaultValue) => int.TryParse(str, out int value) ? value : defaultValue;
    }
}