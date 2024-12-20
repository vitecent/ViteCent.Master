/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Airspace.Dto.Home;
using YPHF.Airspace.Model;
using YPHF.Core.Web;

namespace YPHF.Airspace.Serice
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