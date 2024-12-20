/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Mvc;
using YPHF.Core;
using YPHF.Core.Data;
using YPHF.Core.Web.Api;
using YPHF.Files.Dto.File;

namespace YPHF.Files.Service.FileApi
{
    /// <summary>
    /// 删除文件
    /// </summary>
    [ApiController]
    [Route("File")]
    public class DeleteFile : BaseApi<GetFileArgs, BaseResult>
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="args">参数</param>
        /// <returns>处理结果</returns>
        [HttpPost]
        [Route("DeleteFile")]
        public override async Task<BaseResult> InvokeAsync([FromBody] GetFileArgs args)
        {
            var root = $"{Environment.CurrentDirectory}/wwwroot";

            var exist = await new FileExist().InvokeAsync(args);

            if (!exist.IsSuccessStatusCode)
            {
                return exist;
            }

            BaseFile.Delete($"{root}/{args.Path}");

            return new BaseResult();
        }
    }
}