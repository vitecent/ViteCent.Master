#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
public class AddBaseModuleFieldArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string AddOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string AddWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int AllowNull { get; set; }

    /// <summary>
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string DataType { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string DetailsOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string DetailsWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ExportOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ExportWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int IsIndex { get; set; }

    /// <summary>
    /// </summary>
    public int IsUnique { get; set; }

    /// <summary>
    /// </summary>
    public string ListOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ListWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string MaxLength { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string MinLength { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string PrintOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string PrintWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string SearchOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string SearchWidth { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int ShowInAdd { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInDetails { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInExport { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInList { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInPrint { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInSearch { get; set; }

    /// <summary>
    /// </summary>
    public int ShowInUpdate { get; set; }

    /// <summary>
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// </summary>
    public string UpdateOrder { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string UpdateWidth { get; set; } = string.Empty;
}