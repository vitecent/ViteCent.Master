#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_company")]
public class BaseCompanyEntity : BaseEntity
{
    /// <summary>
    ///     abbreviation
    /// </summary>
    [SugarColumn(ColumnName = "abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     address
    /// </summary>
    [SugarColumn(ColumnName = "address")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    ///     city
    /// </summary>
    [SugarColumn(ColumnName = "city")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    ///     code
    /// </summary>
    [SugarColumn(ColumnName = "code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     country
    /// </summary>
    [SugarColumn(ColumnName = "country")]
    public string Country { get; set; } = string.Empty;

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
    ///     establishDate
    /// </summary>
    [SugarColumn(ColumnName = "establishDate")]
    public DateTime EstablishDate { get; set; }

    /// <summary>
    ///     industry
    /// </summary>
    [SugarColumn(ColumnName = "industry")]
    public string Industry { get; set; } = string.Empty;

    /// <summary>
    ///     legalPerson
    /// </summary>
    [SugarColumn(ColumnName = "legalPerson")]
    public string LegalPerson { get; set; } = string.Empty;

    /// <summary>
    ///     legalPhone
    /// </summary>
    [SugarColumn(ColumnName = "legalPhone")]
    public string LegalPhone { get; set; } = string.Empty;

    /// <summary>
    ///     level
    /// </summary>
    [SugarColumn(ColumnName = "level")]
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     logo
    /// </summary>
    [SugarColumn(ColumnName = "logo")]
    public string Logo { get; set; } = string.Empty;

    /// <summary>
    ///     name
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     parentId
    /// </summary>
    [SugarColumn(ColumnName = "parentId")]
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    ///     province
    /// </summary>
    [SugarColumn(ColumnName = "province")]
    public string Province { get; set; } = string.Empty;
}