#region

using MediatR;
using ViteCent.Basic.Entity.BaseOperation;

#endregion

namespace ViteCent.Basic.Data.BaseOperation;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseOperationEntityArgs : IRequest<BaseOperationEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}