#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
public class GetBaseModuleArgs : BaseArgs, IRequest<DataResult<BaseModuleResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}