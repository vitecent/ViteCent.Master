#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseResourceArgs : BaseArgs, IRequest<DataResult<BaseResourceResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}