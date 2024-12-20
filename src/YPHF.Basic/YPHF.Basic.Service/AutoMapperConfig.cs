/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Basic.Dto.Home;
using YPHF.Basic.Model;
using YPHF.Core.Web;

namespace YPHF.Basic.Service
{
    /// <summary>
    /// </summary>
    public class AutoMapperConfig : BaseMapperConfig
    {
        /// <summary>
        /// </summary>
        public override void Map()
        {
            CreateMap<HomeModel, HomeResult>();
            CreateMap<HomeResult, HomeModel>();
        }
    }
}