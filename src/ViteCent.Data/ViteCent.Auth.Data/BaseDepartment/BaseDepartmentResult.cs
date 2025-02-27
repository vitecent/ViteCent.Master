namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     BaseDepartmentResult
/// </summary>
public class BaseDepartmentResult
{
    /// <summary>
    ///     简称
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

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
    ///     简介
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     级别
    /// </summary>
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     负责人
    /// </summary>
    public string Manager { get; set; } = string.Empty;

    /// <summary>
    ///     负责人电话
    /// </summary>
    public string ManagerPhone { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     父级标识
    /// </summary>
    public string ParentId { get; set; } = string.Empty;

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