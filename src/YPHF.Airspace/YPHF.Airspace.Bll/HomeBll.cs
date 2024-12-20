/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using AutoMapper;
using YPHF.Airspace.Dal;
using YPHF.Airspace.Dto.Home;
using YPHF.Airspace.Model;
using YPHF.Core.Data;
using YPHF.Core.Orm;
using YPHF.Core.Orm.SqlSugar;

namespace YPHF.Airspace.Bll
{
    /// <summary>
    /// </summary>
    public class HomeBll : BaseBll<HomeModel>, IHomeBll
    {
        /// <summary>
        /// </summary>
        private readonly HomeDal dal;

        /// <summary>
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// </summary>
        public HomeBll()
        {
            dal = new HomeDal();

            var context = BaseHttpContext.Context;
            mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
        }

        /// <summary>
        /// </summary>
        public override IBaseDal<HomeModel> DAL => dal;

        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<PageResult<HomeResult>> PageAsync(HomeArgs args)
        {
            var model = await base.PageAsync(args);
            var result = mapper.Map<List<HomeResult>>(model);

            return new PageResult<HomeResult>(args.Offset, args.Limit, args.Total, result);
        }
    }
}