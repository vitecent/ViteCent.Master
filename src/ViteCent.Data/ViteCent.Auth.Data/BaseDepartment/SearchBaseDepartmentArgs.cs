#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     SearchBaseDepartmentArgs
/// </summary>
public class SearchBaseDepartmentArgs : SearchArgs, IRequest<PageResult<BaseDepartmentResult>>
{
}