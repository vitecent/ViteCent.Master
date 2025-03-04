#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
public class AddBaseResourceArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Level { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int Status { get; set; }
}