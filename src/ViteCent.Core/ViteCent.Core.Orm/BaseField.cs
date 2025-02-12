/*
 *
 * 版权所有 ：ViteCent
 * 作   者 : ViteCent
 *
 */

namespace ViteCent.Core.Orm;

/// <summary>
///     Class BaseField.
/// </summary>
public class BaseField
{
    /// <summary>
    ///     Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the DataBase identifier.
    /// </summary>
    /// <value>The DataBase identifier.</value>
    public string DataBaseId { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the index of the is.
    /// </summary>
    /// <value>The index of the is.</value>
    public int IsIndex { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the is nullable.
    /// </summary>
    /// <value>The is nullable.</value>
    public int IsNullable { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the is primary key.
    /// </summary>
    /// <value>The is primary key.</value>
    public int IsPrimaryKey { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the length.
    /// </summary>
    /// <value>The length.</value>
    public int Length { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the remarks.
    /// </summary>
    /// <value>The remarks.</value>
    public string Remarks { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    public int Sequence { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the table identifier.
    /// </summary>
    /// <value>The table identifier.</value>
    public string TableId { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    public string Type { get; set; } = default!;
}