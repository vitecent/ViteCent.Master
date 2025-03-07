#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
/// </summary>
public class GetBaseUserEntityArgs : IRequest<BaseUserEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}