#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseModuleField;

/// <summary>
/// </summary>
public class GetBaseModuleFieldArgs : BaseArgs, IRequest<DataResult<BaseModuleFieldResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}