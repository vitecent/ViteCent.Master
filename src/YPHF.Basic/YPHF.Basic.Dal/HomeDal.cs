/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Basic.Model;
using YPHF.Core.Orm.SqlSugar;

namespace YPHF.Basic.Dal
{
    /// <summary>
    /// </summary>
    /// <summary>
    /// </summary>
    public class HomeDal : BaseDal<HomeModel>, IHomeDal
    {
        /// <summary>
        /// </summary>
        public override string DataBaseName => "XBNET-OMS";
    }
}