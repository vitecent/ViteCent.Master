#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_user_department")]
public class BaseUserDepartmentEntity : CompanyEntity
{
    /// <summary>
    ///     departmentId
    /// </summary>
    [SugarColumn(ColumnName = "departmentId")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    ///     userId
    /// </summary>
    [SugarColumn(ColumnName = "userId")]
    public string UserId { get; set; } = string.Empty;
}