#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     GetBaseDepartmentArgs
/// </summary>
public class GetBaseDepartmentArgs : BaseArgs, IRequest<DataResult<BaseDepartmentResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}