#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserRole;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseUserRoleEntityArgs : IRequest<BaseUserRoleEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}