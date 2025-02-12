﻿/*
 *
 * 版权所有 ：ViteCent
 * 作   者 : ViteCent
 *
 */

namespace ViteCent.Core.Orm;

/// <summary>
///     Class FactoryConfig.
/// </summary>
public class FactoryConfig
{
    /// <summary>
    ///     Gets or sets the type of the DataBase.
    /// </summary>
    /// <value>The type of the DataBase.</value>
    public string DbType { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the master.
    /// </summary>
    /// <value>The master.</value>
    public string Master { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the slaves.
    /// </summary>
    /// <value>The slaves.</value>
    public List<string> Slaves { get; set; } = default!;
}