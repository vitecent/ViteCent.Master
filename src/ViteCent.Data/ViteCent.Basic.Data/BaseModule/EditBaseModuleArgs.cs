namespace ViteCent.Basic.Data.BaseModule;

/// <summary>
/// </summary>
[Serializable]
public class EditBaseModuleArgs : AddBaseModuleArgs
{
    /// <summary>
    /// </summary>
    public string Id { get; set; } = string.Empty;
}