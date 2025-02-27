#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
///     SearchBaseUserDepartmentArgs
/// </summary>
public class SearchBaseUserDepartmentArgs : SearchArgs, IRequest<PageResult<BaseUserDepartmentResult>>
{
}