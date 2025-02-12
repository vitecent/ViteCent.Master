/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Template.Core.Orm.SqlSugar;
using Template.Service.Entity;

#endregion

namespace Template.Service.Domain;

/// <summary>
/// </summary>
/// <summary>
/// </summary>
public class HomeDomain : BaseDomain<HomeEntity>, IHomeDomain
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "Template";
}