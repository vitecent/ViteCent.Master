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
    /// </summary>
    public string Id { get; set; } = string.Empty;
}