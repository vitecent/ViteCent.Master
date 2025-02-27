#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
///     AddBaseUserArgs
/// </summary>
public class AddBaseUserArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     头像
    /// </summary>
    public string Avatar { get; set; } = string.Empty;

    /// <summary>
    ///     出生日期
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     简介
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     邮箱
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     性别
    /// </summary>
    public int Gender { get; set; }

    /// <summary>
    ///     身份证
    /// </summary>
    public string IdCard { get; set; } = string.Empty;

    /// <summary>
    ///     昵称
    /// </summary>
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    ///     密码
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    ///     电话
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    ///     真实姓名
    /// </summary>
    public string RealName { get; set; } = string.Empty;

    /// <summary>
    ///     用户名
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    ///     编号
    /// </summary>
    public string UserNo { get; set; } = string.Empty;
}