/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

namespace YPHF.Core.Orm.SqlSugar;

/// <summary>
/// Class SqlSugarDataBase. Implements the <see cref="YPHF.Core.Orm.BaseDataBase" />
/// </summary>
/// <seealso cref="YPHF.Core.Orm.BaseDataBase" />
public class SqlSugarDataBase : BaseDataBase
{
    /// <summary>
    /// Gets or sets the tables.
    /// </summary>
    /// <value>The tables.</value>
    public List<SqlSugarTable> Tables { get; set; } = default!;
}