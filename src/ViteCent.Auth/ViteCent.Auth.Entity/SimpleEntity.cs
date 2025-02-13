/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Auth.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_airport")]
public class SimpleEntity : BaseEntity
{
    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "Code")]
    public string Code { get; set; } = default!;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "Id", IsPrimaryKey = true)]
    public string Id { get; set; } = default!;

    /// <summary>
    /// </summary>
    [SugarColumn(ColumnName = "Name")]
    public string Name { get; set; } = default!;
}