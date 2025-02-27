namespace ViteCent.Auth.Data.BaseUser;

/// <summary>
///     EditBaseUserArgs
/// </summary>
public class EditBaseUserArgs : AddBaseUserArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}