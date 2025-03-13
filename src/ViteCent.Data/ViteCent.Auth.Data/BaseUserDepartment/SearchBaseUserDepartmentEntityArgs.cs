#region

using MediatR;
using ViteCent.Auth.Entity.BaseUserDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseUserDepartment;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseUserDepartmentEntityArgs : SearchArgs, IRequest<List<BaseUserDepartmentEntity>>
{
}