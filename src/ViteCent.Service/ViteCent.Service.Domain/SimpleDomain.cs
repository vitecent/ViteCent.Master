/*
 *
 * 版权所有 ：ViteCent
 * 作   者 : ViteCent
 *
 */

#region

using ViteCent.Core.Orm.SqlSugar;
using ViteCent.Service.Entity;

#endregion

namespace ViteCent.Service.Domain;

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