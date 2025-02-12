/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using AutoMapper;
using Template.Core.Data;
using Template.Core.Orm;
using Template.Core.Orm.SqlSugar;
using Template.Service.Domain;
using Template.Service.Entity;
using Template.Service.Infrastructure.Home;

#endregion

namespace Template.Service.Application;

/// <summary>
/// </summary>
public class HomeApplication : BaseApplication<HomeEntity>, IHomeApplication
{
    /// <summary>
    /// </summary>
    private readonly HomeDomain dal;

    /// <summary>
    /// </summary>
    private readonly IMapper mapper;

    /// <summary>
    /// </summary>
    public HomeApplication()
    {
        dal = new HomeDomain();

        var context = BaseHttpContext.Context;
        mapper = context.RequestServices.GetService(typeof(IMapper)) as IMapper ?? default!;
    }

    /// <summary>
    /// </summary>
    public override IBaseDomain<HomeEntity> DAL => dal;

    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public async Task<PageResult<HomeResult>> PageAsync(HomeArgs args)
    {
        var Entity = await base.PageAsync(args);
        var result = mapper.Map<List<HomeResult>>(Entity);

        return new PageResult<HomeResult>(args.Offset, args.Limit, args.Total, result);
    }
}