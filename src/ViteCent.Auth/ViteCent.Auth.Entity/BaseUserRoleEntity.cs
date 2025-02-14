#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_user_role")]
public class BaseUserRoleEntity : CompanyEntity
{
    /// <summary>
    ///     departmentId
    /// </summary>
    [SugarColumn(ColumnName = "departmentId")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    ///     roleId
    /// </summary>
    [SugarColumn(ColumnName = "roleId")]
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    ///     userId
    /// </summary>
    [SugarColumn(ColumnName = "userId")]
    public string UserId { get; set; } = string.Empty;
}