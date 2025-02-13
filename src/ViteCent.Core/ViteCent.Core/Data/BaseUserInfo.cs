namespace ViteCent.Core.Data;

/// <summary>
///     Class BaseUserInfo.
/// </summary>
public class BaseUserInfo
{
    /// <summary>
    ///     Gets or sets the authentication.
    /// </summary>
    /// <value>The authentication.</value>
    public List<BaseSystem> Auth { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the company.
    /// </summary>
    /// <value>The company.</value>
    public BaseCompany Company { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the dept.
    /// </summary>
    /// <value>The dept.</value>
    public BaseDept Dept { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the is super admin.
    /// </summary>
    /// <value>The is super admin.</value>
    public int IsSuperAdmin { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = default!;
}