namespace ViteCent.Core.Orm.SqlSugar;

/// <summary>
///     Class SqlSugarDataBase. Implements the <see cref="ViteCent.Core.Orm.BaseDataBase" />
/// </summary>
/// <seealso cref="ViteCent.Core.Orm.BaseDataBase" />
public class SqlSugarDataBase : BaseDataBase
{
    /// <summary>
    ///     Gets or sets the tables.
    /// </summary>
    /// <value>The tables.</value>
    public List<SqlSugarTable> Tables { get; set; } = [];
}