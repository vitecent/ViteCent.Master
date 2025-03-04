#region

using MediatR;
using ViteCent.Auth.Entity;

#endregion

namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
/// </summary>
public class GetBaseCompanyEntityArgs : IRequest<BaseCompanyEntity>
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}