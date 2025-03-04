#region

using MediatR;
using ViteCent.Core.Data;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
/// </summary>
public class GetBaseCompanyArgs : BaseArgs, IRequest<DataResult<BaseCompanyResult>>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}