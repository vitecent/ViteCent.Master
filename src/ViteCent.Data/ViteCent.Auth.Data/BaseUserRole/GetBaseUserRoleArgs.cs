#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseUserRoleArgs : BaseArgs, IRequest<DataResult<BaseUserRoleResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}