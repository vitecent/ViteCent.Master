#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
/// </summary>
public class SearchBaseDepartmentArgs : SearchArgs, IRequest<PageResult<BaseDepartmentResult>>
{
}