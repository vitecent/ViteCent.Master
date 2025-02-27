namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
///     EditBaseResourceArgs
/// </summary>
public class EditBaseResourceArgs : AddBaseResourceArgs
{
    /// <summary>
    ///     标识
    /// </summary>
    public string Id { get; set; } = string.Empty;
}