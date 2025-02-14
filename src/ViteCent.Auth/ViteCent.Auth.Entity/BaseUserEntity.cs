#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
///     Class BaseUserEntity.
/// </summary>
[Serializable]
[SugarTable("base_user")]
public class BaseUserEntity : CompanyEntity
{
    /// <summary>
    ///     avatar
    /// </summary>
    [SugarColumn(ColumnName = "avatar")]
    public string Avatar { get; set; } = string.Empty;

    /// <summary>
    ///     birthday
    /// </summary>
    [SugarColumn(ColumnName = "birthday")]
    public DateTime Birthday { get; set; }

    /// <summary>
    ///     description
    /// </summary>
    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     email
    /// </summary>
    [SugarColumn(ColumnName = "email")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     gender
    /// </summary>
    [SugarColumn(ColumnName = "gender")]
    public int Gender { get; set; }

    /// <summary>
    ///     idCard
    /// </summary>
    [SugarColumn(ColumnName = "idCard")]
    public string IdCard { get; set; } = string.Empty;

    /// <summary>
    ///     nickname
    /// </summary>
    [SugarColumn(ColumnName = "nickname")]
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    ///     password
    /// </summary>
    [SugarColumn(ColumnName = "password")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    ///     phone
    /// </summary>
    [SugarColumn(ColumnName = "phone")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    ///     realName
    /// </summary>
    [SugarColumn(ColumnName = "realName")]
    public string RealName { get; set; } = string.Empty;

    /// <summary>
    ///     username
    /// </summary>
    [SugarColumn(ColumnName = "username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    ///     userNo
    /// </summary>
    [SugarColumn(ColumnName = "userNo")]
    public string UserNo { get; set; } = string.Empty;
}