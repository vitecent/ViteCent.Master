/*
 *
 * 作    者 ：vitecent
 * 作   者 : ViteCent
 *
 */

#region

using ViteCent.Core.Orm.SqlSugar;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Domain;

/// <summary>
/// </summary>
/// <summary>
/// </summary>
public class SimpleDomain : BaseDomain<SimpleEntity>, ISimpleDomain
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent";
}