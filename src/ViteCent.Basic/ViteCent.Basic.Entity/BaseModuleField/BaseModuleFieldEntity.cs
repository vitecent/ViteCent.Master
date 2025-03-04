#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_module_field")]
public class BaseModuleFieldEntity : BaseEntity, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "abbreviation", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "简称")]
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "addOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "新增排序")]
    public string AddOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "addWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "新增宽度")]
    public string AddWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "allowNull", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "允许为空")]
    public int AllowNull { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "code", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "编码")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "companyId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "公司标识")]
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "createTime", IsNullable = true, ColumnDataType = "datetime", ColumnDescription = "创建时间")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "creator", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "创建人")]
    public string Creator { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "dataType", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "类型")]
    public string DataType { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "dataVersion", ColumnDataType = "timestamp", ColumnDescription = "数据版本")]
    public DateTime DataVersion { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "description", IsNullable = true, ColumnDataType = "varchar", Length = 5000, ColumnDescription = "简介")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "detailsOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "详情排序")]
    public string DetailsOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "detailsWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "详情宽度")]
    public string DetailsWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "exportOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "导出排序")]
    public string ExportOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "exportWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "导出宽度")]
    public string ExportWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "id", ColumnDataType = "varchar", Length = 50, ColumnDescription = "标识", IsPrimaryKey = true)]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "isIndex", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "是否索引")]
    public int IsIndex { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "isUnique", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "是否唯一")]
    public int IsUnique { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "listOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "列表排序")]
    public string ListOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "listWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "列表宽度")]
    public string ListWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "maxLength", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "最大长度")]
    public string MaxLength { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "minLength", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "最小长度")]
    public string MinLength { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "moduleId", ColumnDataType = "varchar", Length = 50, ColumnDescription = "模块标识")]
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "name", ColumnDataType = "varchar", Length = 100, ColumnDescription = "名称")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "printOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "打印排序")]
    public string PrintOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "printWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "打印宽度")]
    public string PrintWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "searchOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "搜索排序")]
    public string SearchOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "searchWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "搜索宽度")]
    public string SearchWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInAdd", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "新增可见")]
    public int ShowInAdd { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInDetails", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "详情可见")]
    public int ShowInDetails { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInExport", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "导出可见")]
    public int ShowInExport { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInList", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "列表可见")]
    public int ShowInList { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInPrint", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "打印可见")]
    public int ShowInPrint { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInSearch", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "搜索可见")]
    public int ShowInSearch { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "showInUpdate", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "修改可见")]
    public int ShowInUpdate { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "status", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "状态")]
    public int Status { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "updateOrder", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "修改排序")]
    public string UpdateOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "updater", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "修改人")]
    public string Updater { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "updateTime", IsNullable = true, ColumnDataType = "datetime", ColumnDescription = "修改时间")]
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "updateWidth", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "修改宽度")]
    public string UpdateWidth { get; set; } = string.Empty;
}