#region

using MediatR;
using ViteCent.Auth.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
///     SearchEntityArgs
/// </summary>
public class SearchBaseCompanyEntityArgs : SearchArgs, IRequest<List<BaseCompanyEntity>>
{
}