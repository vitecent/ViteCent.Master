#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     AddBaseDepartmentArgs
/// </summary>
public class AddBaseDepartmentArgs : BaseArgs, IRequest<BaseResult>
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
    ///     级别
    /// </summary>
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     负责人
    /// </summary>
    public string Manager { get; set; } = string.Empty;

    /// <summary>
    ///     负责人电话
    /// </summary>
    public string ManagerPhone { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     父级标识
    /// </summary>
    public string ParentId { get; set; } = string.Empty;
}