/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Orm.SqlSugar;
using YPHF.Job.Model;

#endregion

namespace YPHF.Job.Dal;

/// <summary>
/// </summary>
/// <summary>
/// </summary>
public class HomeDal : BaseDal<HomeModel>, IHomeDal
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "YPHF";
}