#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
///     AddBaseCompanyArgs
/// </summary>
public class AddBaseCompanyArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     简称
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     详细地址
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    ///     城市
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    ///     编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     国家
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    ///     简介
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     邮箱
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     成立日期
    /// </summary>
    public DateTime? EstablishDate { get; set; }

    /// <summary>
    ///     行业
    /// </summary>
    public string Industry { get; set; } = string.Empty;

    /// <summary>
    ///     法人
    /// </summary>
    public string LegalPerson { get; set; } = string.Empty;

    /// <summary>
    ///     法人电话
    /// </summary>
    public string LegalPhone { get; set; } = string.Empty;

    /// <summary>
    ///     级别
    /// </summary>
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     商标
    /// </summary>
    public string Logo { get; set; } = string.Empty;

    /// <summary>
    ///     名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     父级标识
    /// </summary>
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    ///     省份
    /// </summary>
    public string Province { get; set; } = string.Empty;
}