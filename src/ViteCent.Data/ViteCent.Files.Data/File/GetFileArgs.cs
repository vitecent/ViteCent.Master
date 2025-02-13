#region

using ViteCent.Core.Data;

#endregion

namespace ViteCent.Files.Data.File;

/// <summary>
/// </summary>
public class GetFileArgs : BaseArgs
{
    /// <summary>
    ///     文件路径
    /// </summary>
    public string Path { get; set; } = default!;
}