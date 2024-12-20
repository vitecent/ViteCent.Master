/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using SqlSugar;
using YPHF.Core.Orm.SqlSugar;

#endregion

namespace YPHF.Plan.Model;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_airport")]
public class HomeModel : BaseModel
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