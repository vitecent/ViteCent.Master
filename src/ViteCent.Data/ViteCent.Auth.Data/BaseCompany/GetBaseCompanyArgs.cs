#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
///     GetBaseCompanyArgs
/// </summary>
public class GetBaseCompanyArgs : BaseArgs, IRequest<DataResult<BaseCompanyResult>>
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}