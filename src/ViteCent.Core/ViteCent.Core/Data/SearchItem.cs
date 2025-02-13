﻿/*
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
///     Class SearchItem.
/// </summary>
public class SearchItem
{
    /// <summary>
    ///     Gets or sets the field.
    /// </summary>
    /// <value>The field.</value>
    public string Field { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the group.
    /// </summary>
    /// <value>The group.</value>
    public string Group { get; set; } = "";

    /// <summary>
    ///     Gets or sets the method.
    /// </summary>
    /// <value>The method.</value>
    public SearchEnum Method { get; set; } = SearchEnum.Equal;

    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    /// <value>The value.</value>
    public object Value { get; set; } = default!;
}