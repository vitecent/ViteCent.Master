#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
public class SearchBaseUserDepartmentEntityArgs : SearchArgs, IRequest<List<BaseUserDepartmentEntity>>
{
}