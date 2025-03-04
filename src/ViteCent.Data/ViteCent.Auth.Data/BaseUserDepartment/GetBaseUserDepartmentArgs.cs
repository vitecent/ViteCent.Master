#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
public class GetBaseUserDepartmentArgs : BaseArgs, IRequest<DataResult<BaseUserDepartmentResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}