#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
///     GetBaseUserArgs
/// </summary>
public class GetBaseUserArgs : BaseArgs, IRequest<DataResult<BaseUserResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}