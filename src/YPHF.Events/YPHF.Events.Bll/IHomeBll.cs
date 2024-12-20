/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Core.Data;
using YPHF.Events.Dto.Home;

namespace YPHF.Events.Bll
{
    /// <summary>
    /// </summary>
    public interface IHomeBll
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<PageResult<HomeResult>> PageAsync(HomeArgs args);
    }
}