#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
///     BaseDepartmentEntity.
/// </summary>
[Serializable]
[SugarTable("base_department")]
public class BaseDepartmentEntity : CompanyEntity, IRequest<BaseResult>
{
    /// <summary>
    ///     简称
    /// </summary>
    [SugarColumn(ColumnName = "abbreviation", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "简称")]
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     编码
    /// </summary>
    [SugarColumn(ColumnName = "code", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "编码")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     简介
    /// </summary>
    [SugarColumn(ColumnName = "description", IsNullable = true, ColumnDataType = "varchar", Length = 5000, ColumnDescription = "简介")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     级别
    /// </summary>
    [SugarColumn(ColumnName = "level", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "级别")]
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     负责人
    /// </summary>
    [SugarColumn(ColumnName = "manager", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "负责人")]
    public string Manager { get; set; } = string.Empty;

    /// <summary>
    ///     负责人电话
    /// </summary>
    [SugarColumn(ColumnName = "managerPhone", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "负责人电话")]
    public string ManagerPhone { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    [SugarColumn(ColumnName = "name", ColumnDataType = "varchar", Length = 100, ColumnDescription = "名称")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     父级标识
    /// </summary>
    [SugarColumn(ColumnName = "parentId", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "父级标识")]
    public string ParentId { get; set; } = string.Empty;
}