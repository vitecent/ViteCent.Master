#region

using MediatR;
using ViteCent.Basic.Entity.BaseResource;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseResourceEntityArgs : IRequest<BaseResourceEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}