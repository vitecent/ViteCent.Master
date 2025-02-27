namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     EditBaseRolePermissionArgs
/// </summary>
public class EditBaseRolePermissionArgs : AddBaseRolePermissionArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}