#region

using MediatR;
using ViteCent.Auth.Entity.BaseDepartment;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
/// </summary>
[Serializable]
public class SearchBaseDepartmentEntityArgs : SearchArgs, IRequest<List<BaseDepartmentEntity>>
{
}