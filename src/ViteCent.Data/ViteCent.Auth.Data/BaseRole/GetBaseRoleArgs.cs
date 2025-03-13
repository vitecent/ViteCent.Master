#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseRole;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseRoleArgs : BaseArgs, IRequest<DataResult<BaseRoleResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}