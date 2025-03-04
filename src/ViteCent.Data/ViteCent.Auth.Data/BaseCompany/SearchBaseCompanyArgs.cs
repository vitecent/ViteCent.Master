#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
/// </summary>
public class SearchBaseCompanyArgs : SearchArgs, IRequest<PageResult<BaseCompanyResult>>
{
}