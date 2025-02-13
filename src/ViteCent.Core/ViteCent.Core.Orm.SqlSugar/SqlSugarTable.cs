namespace ViteCent.Core.Orm.SqlSugar;

/// <summary>
///     Class SqlSugarTable. Implements the <see cref="ViteCent.Core.Orm.BaseTable" />
/// </summary>
/// <seealso cref="ViteCent.Core.Orm.BaseTable" />
public class SqlSugarTable : BaseTable
{
    /// <summary>
    ///     Gets or sets the fields.
    /// </summary>
    /// <value>The fields.</value>
    public List<SqlSugarField> Fields { get; set; } = default!;
}