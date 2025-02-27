#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserRole;

/// <summary>
///     GetBaseUserRoleArgs
/// </summary>
public class GetBaseUserRoleArgs : BaseArgs, IRequest<DataResult<BaseUserRoleResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}