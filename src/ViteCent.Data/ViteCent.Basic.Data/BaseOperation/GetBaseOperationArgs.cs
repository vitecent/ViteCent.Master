#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
///     GetBaseOperationArgs
/// </summary>
public class GetBaseOperationArgs : BaseArgs, IRequest<DataResult<BaseOperationResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}