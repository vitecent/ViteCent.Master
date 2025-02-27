#region

using MediatR;
using ViteCent.Basic.Entity;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
public class GetBaseResourceEntityArgs : IRequest<BaseResourceEntity>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}