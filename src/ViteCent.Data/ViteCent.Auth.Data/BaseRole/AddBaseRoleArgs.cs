#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
///     AddBaseRoleArgs
/// </summary>
public class AddBaseRoleArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     简称
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     简介
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; } = string.Empty;
}