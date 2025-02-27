#region

using MediatR;
using ViteCent.Basic.Entity;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
/// </summary>
public class GetBaseOperationEntityArgs : IRequest<BaseOperationEntity>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}