#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class DeleteBaseResourceEntityArgs : IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}