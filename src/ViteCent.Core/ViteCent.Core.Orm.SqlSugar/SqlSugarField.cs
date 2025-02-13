/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using ViteCent.Core.Enums;

#endregion

namespace ViteCent.Core.Orm.SqlSugar;

/// <summary>
///     Class SqlSugarField. Implements the <see cref="ViteCent.Core.Orm.BaseField" />
/// </summary>
/// <seealso cref="ViteCent.Core.Orm.BaseField" />
public class SqlSugarField : BaseField
{
    /// <summary>
    ///     Gets the type of the column.
    /// </summary>
    /// <value>The type of the column.</value>
    public string ColumnType => Length < 1 ? Type : $"{Type}({Length})";

    /// <summary>
    ///     Gets the type of the data.
    /// </summary>
    /// <value>The type of the data.</value>
    public string DataType => Type.Replace("varchar", "string")
        .Replace("nvarchar", "string")
        .Replace("sql_variant", "string")
        .Replace("text", "string")
        .Replace("char", "string")
        .Replace("ntext", "string")
        .Replace("hierarchyid", "string")
        .Replace("bit", "bool")
        .Replace("datetime", "DateTime")
        .Replace("datetime2", "DateTime")
        .Replace("date", "DateTime")
        .Replace("time", "DateTime")
        .Replace("smalldatetime", "DateTime")
        .Replace("DateTimestamp", "DateTime")
        .Replace("tinyint", "byte")
        .Replace("bigint", "long")
        .Replace("longstring", "long")
        .Replace("single", "decimal")
        .Replace("money", "decimal")
        .Replace("numeric", "decimal")
        .Replace("smallmoney", "decimal")
        .Replace("float", "decimal")
        .Replace("real", "float")
        .Replace("smallint", "short")
        .Replace("uniqueidentifier", "Guid")
        .Replace("smallmoney", "decimal");

    /// <summary>
    ///     Gets the has primary.
    /// </summary>
    /// <value>The has primary.</value>
    public string HasPrimary => IsPrimaryKey == (int)YesNoEnum.Yes ? "IsPrimaryKey = true, " : "";
}