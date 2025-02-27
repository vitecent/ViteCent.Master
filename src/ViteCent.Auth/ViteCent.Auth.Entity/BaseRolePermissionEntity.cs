#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
///     BaseRolePermissionEntity.
/// </summary>
[Serializable]
[SugarTable("base_role_permission")]
public class BaseRolePermissionEntity : CompanyEntity, IRequest<BaseResult>
{
    /// <summary>
    ///     模块标识
    /// </summary>
    [SugarColumn(ColumnName = "moduleId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "模块标识")]
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     操作标识
    /// </summary>
    [SugarColumn(ColumnName = "operationId", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "操作标识")]
    public string OperationId { get; set; } = string.Empty;

    /// <summary>
    ///     资源标识
    /// </summary>
    [SugarColumn(ColumnName = "resourceId", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "资源标识")]
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    ///     角色标识
    /// </summary>
    [SugarColumn(ColumnName = "roleId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "角色标识")]
    public string RoleId { get; set; } = string.Empty;
}