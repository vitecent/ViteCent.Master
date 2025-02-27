namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
///     EditBaseUserRoleArgs
/// </summary>
public class EditBaseUserRoleArgs : AddBaseUserRoleArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}