#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
///     GetBaseResourceArgs
/// </summary>
public class GetBaseResourceArgs : BaseArgs, IRequest<DataResult<BaseResourceResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}