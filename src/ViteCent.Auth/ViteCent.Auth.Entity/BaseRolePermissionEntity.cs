#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_role_permission")]
public class BaseRolePermissionEntity : CompanyEntity
{
    /// <summary>
    ///     moduleId
    /// </summary>
    [SugarColumn(ColumnName = "moduleId")]
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     operationId
    /// </summary>
    [SugarColumn(ColumnName = "operationId")]
    public string OperationId { get; set; } = string.Empty;

    /// <summary>
    ///     resourceId
    /// </summary>
    [SugarColumn(ColumnName = "resourceId")]
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    ///     roleId
    /// </summary>
    [SugarColumn(ColumnName = "roleId")]
    public string RoleId { get; set; } = string.Empty;
}