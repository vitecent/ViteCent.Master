namespace ViteCent.Auth.Data.BaseCompany;

/// <summary>
///     EditBaseCompanyArgs
/// </summary>
public class EditBaseCompanyArgs : AddBaseCompanyArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}