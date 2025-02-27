#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
///     SearchBaseResourceArgs
/// </summary>
public class SearchBaseResourceArgs : SearchArgs, IRequest<PageResult<BaseResourceResult>>
{
}