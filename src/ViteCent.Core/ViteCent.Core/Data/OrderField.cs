/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using ViteCent.Core.Enums;

#endregion

namespace ViteCent.Core.Data;

/// <summary>
///     Class OrderField.
/// </summary>
public class OrderField
{
    /// <summary>
    ///     Gets or sets the field.
    /// </summary>
    /// <value>The field.</value>
    public string Field { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the type of the order.
    /// </summary>
    /// <value>The type of the order.</value>
    public OrderEnum OrderType { get; set; } = OrderEnum.Desc;
}