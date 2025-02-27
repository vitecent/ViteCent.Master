#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
///     AddBaseUserDepartmentArgs
/// </summary>
public class AddBaseUserDepartmentArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    ///     公司标识
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    ///     部门标识
    /// </summary>
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    ///     用户标识
    /// </summary>
    public string UserId { get; set; } = string.Empty;
}