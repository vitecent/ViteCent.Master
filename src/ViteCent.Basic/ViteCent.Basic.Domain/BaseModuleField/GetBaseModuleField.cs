#region

using MediatR;
using ViteCent.Basic.Data.BaseModuleField;
using ViteCent.Basic.Entity;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Basic.Domain.BaseModuleField;

/// <summary>
///     GetBaseModuleField
/// </summary>
public class GetBaseModuleField : BaseDomain<BaseModuleFieldEntity>, IRequestHandler<GetBaseModuleFieldEntityArgs, BaseModuleFieldEntity>
{
    /// <summary>
    ///     DataBaseName
    /// </summary>
    public override string DataBaseName => "ViteCent.Basic";

    /// <summary>
    ///     Handle
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<BaseModuleFieldEntity> Handle(GetBaseModuleFieldEntityArgs request, CancellationToken cancellationToken)
    {
        return await base.GetAsync(x => x.Id == request.Id);
    }
}