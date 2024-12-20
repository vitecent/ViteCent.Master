/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using YPHF.Core.Data;

#endregion

namespace YPHF.Files.Dto.File;

/// <summary>
/// </summary>
public class GetFileArgs : BaseArgs
{
    /// <summary>
    ///     文件路径
    /// </summary>
    public string Path { get; set; } = default!;
}