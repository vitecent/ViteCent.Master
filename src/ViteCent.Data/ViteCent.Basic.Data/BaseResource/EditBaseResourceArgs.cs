namespace ViteCent.Basic.Data.BaseResource;

/// <summary>
/// </summary>
[Serializable]
public class EditBaseResourceArgs : AddBaseResourceArgs
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}