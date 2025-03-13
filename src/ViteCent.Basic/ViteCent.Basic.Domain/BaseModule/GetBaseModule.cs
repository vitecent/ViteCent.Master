#region

using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Basic.Entity.BaseModule;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
/// </summary>
public class GetBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<GetBaseModuleEntityArgs, BaseModuleEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseModuleEntity> Handle(GetBaseModuleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}