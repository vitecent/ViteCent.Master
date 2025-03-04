#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
/// </summary>
public class GetBaseDepartmentArgs : BaseArgs, IRequest<DataResult<BaseDepartmentResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}