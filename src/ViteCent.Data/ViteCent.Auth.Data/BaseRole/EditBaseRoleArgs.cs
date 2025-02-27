namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
///     EditBaseRoleArgs
/// </summary>
public class EditBaseRoleArgs : AddBaseRoleArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}