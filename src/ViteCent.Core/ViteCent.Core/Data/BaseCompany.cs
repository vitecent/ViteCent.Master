/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

namespace ViteCent.Core.Data;

/// <summary>
///     Class BaseCompany.
/// </summary>
public class BaseCompany
{
    /// <summary>
    ///     Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = default!;
}