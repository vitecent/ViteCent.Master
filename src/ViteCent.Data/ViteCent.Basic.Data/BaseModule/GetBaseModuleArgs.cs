#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
///     GetBaseModuleArgs
/// </summary>
public class GetBaseModuleArgs : BaseArgs, IRequest<DataResult<BaseModuleResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}