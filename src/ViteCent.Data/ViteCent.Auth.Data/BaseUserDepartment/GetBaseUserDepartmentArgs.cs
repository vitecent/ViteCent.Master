#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
///     GetBaseUserDepartmentArgs
/// </summary>
public class GetBaseUserDepartmentArgs : BaseArgs, IRequest<DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}