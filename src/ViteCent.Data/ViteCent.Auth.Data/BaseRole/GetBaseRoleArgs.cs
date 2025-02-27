#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
///     GetBaseRoleArgs
/// </summary>
public class GetBaseRoleArgs : BaseArgs, IRequest<DataResult<BaseRoleResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}