/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Enums;

#endregion

namespace YPHF.Core.Orm;

/// <summary>
/// Class Command.
/// </summary>
public class Command
{
    /// <summary>
    /// Gets or sets the type of the command.
    /// </summary>
    /// <value>The type of the command.</value>
    public CommandEnum CommandType { get; set; }

    /// <summary>
    /// Gets or sets the type of the data.
    /// </summary>
    /// <value>The type of the data.</value>
    public DataEnum DataType { get; set; }

    /// <summary>
    /// Gets or sets the model.
    /// </summary>
    /// <value>The model.</value>
    public dynamic Model { get; set; } = default!;

    /// <summary>
    /// Gets or sets the parameters.
    /// </summary>
    /// <value>The parameters.</value>
    public object Parameters { get; set; } = default!;

    /// <summary>
    /// Gets or sets the SQL.
    /// </summary>
    /// <value>The SQL.</value>
    public string SQL { get; set; } = default!;

    /// <summary>
    /// Gets or sets the where.
    /// </summary>
    /// <value>The where.</value>
    public dynamic Where { get; set; } = default!;
}