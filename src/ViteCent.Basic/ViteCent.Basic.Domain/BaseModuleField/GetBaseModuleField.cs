#region

using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Entity.BaseModuleField;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
/// </summary>
public class GetBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<GetBaseModuleFieldEntityArgs, BaseModuleFieldEntity>
{
    /// <summary>
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseModuleFieldEntity> Handle(GetBaseModuleFieldEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id && x.CompanyId == request.CompanyId);
    }
}