#region

using MediatR;
using ViteCent.Basic.Data.BaseModule;
using ViteCent.Basic.Entity.BaseModule;
using ViteCent.Core.Data;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModule;

/// <summary>
/// </summary>
public class DeleteBaseModule : BaseDomain<BaseModuleEntity>, IRequestHandler<DeleteBaseModuleEntityArgs, BaseResult>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseResult> Handle(DeleteBaseModuleEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.DeleteAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}