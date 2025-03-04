#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
public class AddBaseUserDepartmentArgs : BaseArgs, IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// </summary>
    public string UserId { get; set; } = string.Empty;
}