/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using YPHF.Core.Data;

namespace YPHF.Files.Dto.File
{
    /// <summary>
    /// </summary>
    public class GetFileArgs : BaseArgs
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; set; } = default!;
    }
}