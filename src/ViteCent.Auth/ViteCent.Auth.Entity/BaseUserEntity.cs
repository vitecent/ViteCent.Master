#region

using MediatR;
using SqlSugar;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
///     BaseUserEntity.
/// </summary>
[Serializable]
[SugarTable("base_user")]
public class BaseUserEntity : CompanyEntity, IRequest<BaseResult>
{
    /// <summary>
    ///     头像
    /// </summary>
    [SugarColumn(ColumnName = "avatar", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "头像")]
    public string Avatar { get; set; } = string.Empty;

    /// <summary>
    ///     出生日期
    /// </summary>
    [SugarColumn(ColumnName = "birthday", IsNullable = true, ColumnDataType = "date", ColumnDescription = "出生日期")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    ///     简介
    /// </summary>
    [SugarColumn(ColumnName = "description", IsNullable = true, ColumnDataType = "varchar", Length = 5000, ColumnDescription = "简介")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     邮箱
    /// </summary>
    [SugarColumn(ColumnName = "email", IsNullable = true, ColumnDataType = "varchar", Length = 100, ColumnDescription = "邮箱")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     性别
    /// </summary>
    [SugarColumn(ColumnName = "gender", IsNullable = true, ColumnDataType = "int", Length = 11, ColumnDescription = "性别")]
    public int Gender { get; set; }

    /// <summary>
    ///     身份证
    /// </summary>
    [SugarColumn(ColumnName = "idCard", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "身份证")]
    public string IdCard { get; set; } = string.Empty;

    /// <summary>
    ///     昵称
    /// </summary>
    [SugarColumn(ColumnName = "nickname", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "昵称")]
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    ///     密码
    /// </summary>
    [SugarColumn(ColumnName = "password", ColumnDataType = "varchar", Length = 50, ColumnDescription = "密码")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    ///     电话
    /// </summary>
    [SugarColumn(ColumnName = "phone", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "电话")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    ///     真实姓名
    /// </summary>
    [SugarColumn(ColumnName = "realName", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "真实姓名")]
    public string RealName { get; set; } = string.Empty;

    /// <summary>
    ///     用户名
    /// </summary>
    [SugarColumn(ColumnName = "username", ColumnDataType = "varchar", Length = 50, ColumnDescription = "用户名")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    ///     编号
    /// </summary>
    [SugarColumn(ColumnName = "userNo", IsNullable = true, ColumnDataType = "varchar", Length = 50, ColumnDescription = "编号")]
    public string UserNo { get; set; } = string.Empty;
}