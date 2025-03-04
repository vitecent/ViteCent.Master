#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
public class GetBaseUserDepartmentEntityArgs : IRequest<BaseUserDepartmentEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}