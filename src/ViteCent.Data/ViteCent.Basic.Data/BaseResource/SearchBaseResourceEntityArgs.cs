#region

using MediatR;
using ViteCent.Basic.Entity;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
public class SearchBaseResourceEntityArgs : SearchArgs, IRequest<List<BaseResourceEntity>>
{
}