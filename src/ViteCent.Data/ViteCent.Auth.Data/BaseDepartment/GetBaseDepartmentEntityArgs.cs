#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
/// </summary>
public class GetBaseDepartmentEntityArgs : IRequest<BaseDepartmentEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}