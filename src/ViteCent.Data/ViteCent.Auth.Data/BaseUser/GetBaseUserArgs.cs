#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseUserArgs : BaseArgs, IRequest<DataResult<BaseUserResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}