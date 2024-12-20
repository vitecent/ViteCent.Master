﻿/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

namespace YPHF.Core
{
    /// <summary>
    /// DoubleHelper
    /// </summary>
    public static class DoubleHelper
    {
        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.Double.</returns>
        public static double GetDouble(this string str) => str.GetDouble(default);

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Double.</returns>
        public static double GetDouble(this string str, double defaultValue) => double.TryParse(str, out double value) ? value : defaultValue;
    }
}