#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseDepartment;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseDepartmentEntityArgs : SearchArgs, IRequest<List<BaseDepartmentEntity>>
{
}