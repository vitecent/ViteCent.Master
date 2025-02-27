#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
///     AddBaseModuleFieldArgs
/// </summary>
public class AddBaseModuleFieldArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     简称
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     新增排序
    /// </summary>
    public string AddOrder { get; set; } = string.Empty;

    /// <summary>
    ///     新增宽度
    /// </summary>
    public string AddWidth { get; set; } = string.Empty;

    /// <summary>
    ///     允许为空
    /// </summary>
    public int AllowNull { get; set; }

    /// <summary>
    ///     编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     类型
    /// </summary>
    public string DataType { get; set; } = string.Empty;

    /// <summary>
    ///     简介
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     详情排序
    /// </summary>
    public string DetailsOrder { get; set; } = string.Empty;

    /// <summary>
    ///     详情宽度
    /// </summary>
    public string DetailsWidth { get; set; } = string.Empty;

    /// <summary>
    ///     导出排序
    /// </summary>
    public string ExportOrder { get; set; } = string.Empty;

    /// <summary>
    ///     导出宽度
    /// </summary>
    public string ExportWidth { get; set; } = string.Empty;

    /// <summary>
    ///     是否索引
    /// </summary>
    public int IsIndex { get; set; }

    /// <summary>
    ///     是否唯一
    /// </summary>
    public int IsUnique { get; set; }

    /// <summary>
    ///     列表排序
    /// </summary>
    public string ListOrder { get; set; } = string.Empty;

    /// <summary>
    ///     列表宽度
    /// </summary>
    public string ListWidth { get; set; } = string.Empty;

    /// <summary>
    ///     最大长度
    /// </summary>
    public string MaxLength { get; set; } = string.Empty;

    /// <summary>
    ///     最小长度
    /// </summary>
    public string MinLength { get; set; } = string.Empty;

    /// <summary>
    ///     模块标识
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     打印排序
    /// </summary>
    public string PrintOrder { get; set; } = string.Empty;

    /// <summary>
    ///     打印宽度
    /// </summary>
    public string PrintWidth { get; set; } = string.Empty;

    /// <summary>
    ///     搜索排序
    /// </summary>
    public string SearchOrder { get; set; } = string.Empty;

    /// <summary>
    ///     搜索宽度
    /// </summary>
    public string SearchWidth { get; set; } = string.Empty;

    /// <summary>
    ///     新增可见
    /// </summary>
    public int ShowInAdd { get; set; }

    /// <summary>
    ///     详情可见
    /// </summary>
    public int ShowInDetails { get; set; }

    /// <summary>
    ///     导出可见
    /// </summary>
    public int ShowInExport { get; set; }

    /// <summary>
    ///     列表可见
    /// </summary>
    public int ShowInList { get; set; }

    /// <summary>
    ///     打印可见
    /// </summary>
    public int ShowInPrint { get; set; }

    /// <summary>
    ///     搜索可见
    /// </summary>
    public int ShowInSearch { get; set; }

    /// <summary>
    ///     修改可见
    /// </summary>
    public int ShowInUpdate { get; set; }

    /// <summary>
    ///     修改排序
    /// </summary>
    public string UpdateOrder { get; set; } = string.Empty;

    /// <summary>
    ///     修改宽度
    /// </summary>
    public string UpdateWidth { get; set; } = string.Empty;
}