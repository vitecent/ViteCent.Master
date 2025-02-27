namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
///     BaseUserDepartmentResult
/// </summary>
public class BaseUserDepartmentResult
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
    ///     创建人
    /// </summary>
    public string Creator { get; set; } = string.Empty;

    /// <summary>
    ///     数据版本
    /// </summary>
    public DateTime DataVersion { get; set; }

    /// <summary>
    ///     部门标识
    /// </summary>
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;

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

    /// <summary>
    ///     用户标识
    /// </summary>
    public string UserId { get; set; } = string.Empty;
}