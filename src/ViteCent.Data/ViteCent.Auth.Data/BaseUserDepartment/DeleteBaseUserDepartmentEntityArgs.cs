#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
[Serializable]
public class DeleteBaseUserDepartmentEntityArgs : IRequest<BaseResult>
{
    /// <summary>
    /// </summary>
    public string CompanyId { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}