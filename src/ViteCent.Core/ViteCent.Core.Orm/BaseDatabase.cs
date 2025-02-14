namespace ViteCent.Core.Orm;

/// <summary>
///     Class BaseDataBase.
/// </summary>
public class BaseDataBase
{
    /// <summary>
    ///     Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the remarks.
    /// </summary>
    /// <value>The remarks.</value>
    public string Remarks { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    public int Sequence { get; set; }
}