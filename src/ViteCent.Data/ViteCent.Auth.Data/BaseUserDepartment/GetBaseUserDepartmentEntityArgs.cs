#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserDepartment;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
[Serializable]
public class GetBaseUserDepartmentEntityArgs : IRequest<BaseUserDepartmentEntity>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}