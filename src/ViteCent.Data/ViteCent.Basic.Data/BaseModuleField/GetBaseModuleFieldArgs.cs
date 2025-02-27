#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
///     GetBaseModuleFieldArgs
/// </summary>
public class GetBaseModuleFieldArgs : BaseArgs, IRequest<DataResult<BaseModuleFieldResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}