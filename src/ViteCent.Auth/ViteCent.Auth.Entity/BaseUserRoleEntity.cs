#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
///     BaseUserRoleEntity.
/// </summary>
[Serializable]
[SugarTable("base_user_role")]
public class BaseUserRoleEntity : CompanyEntity, IRequest<BaseResult>
{
    /// <summary>
    ///     部门标识
    /// </summary>
    [SugarColumn(ColumnName = "departmentId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "部门标识")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    ///     角色标识
    /// </summary>
    [SugarColumn(ColumnName = "roleId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "角色标识")]
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    ///     用户标识
    /// </summary>
    [SugarColumn(ColumnName = "userId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "用户标识")]
    public string UserId { get; set; } = string.Empty;
}