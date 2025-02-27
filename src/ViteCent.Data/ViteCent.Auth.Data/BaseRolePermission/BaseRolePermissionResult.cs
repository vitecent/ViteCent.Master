namespace ViteCent.Auth.Data.BaseRolePermission;

/// <summary>
///     BaseRolePermissionResult
/// </summary>
public class BaseRolePermissionResult
{
    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    ///     数据版本
    /// </summary>
    public DateTime DataVersion { get; set; }

    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     模块标识
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     操作标识
    /// </summary>
    public string OperationId { get; set; } = string.Empty;

    /// <summary>
    ///     资源标识
    /// </summary>
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    ///     角色标识
    /// </summary>
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    ///     状态
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    ///     修改人
    /// </summary>
    public string Updater { get; set; } = string.Empty;

    /// <summary>
    ///     修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}