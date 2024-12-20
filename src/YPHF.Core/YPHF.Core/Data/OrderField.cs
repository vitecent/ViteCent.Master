/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Core.Enums;

namespace YPHF.Core.Data
{
    /// <summary>
    /// Class OrderField.
    /// </summary>
    public class OrderField
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        public string Field { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type of the order.
        /// </summary>
        /// <value>The type of the order.</value>
        public OrderEnum OrderType { get; set; } = OrderEnum.Desc;
    }
}