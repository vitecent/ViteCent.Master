/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

using System.Text.Json;
using YPHF.Core.Data;

#endregion

namespace YPHF.Core.Web.Filter;

/// <summary>
/// </summary>
public class BaseExceptionFilter : IExceptionFilter
{
    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    public async void OnException(ExceptionContext context)
    {
        var logger =
            context.HttpContext.RequestServices.GetService(typeof(ILogger<BaseExceptionFilter>)) as
                ILogger<BaseExceptionFilter> ?? default!;
        logger.LogError(context.Exception, context.Exception.Message);

        var result = new BaseResult(500, context.Exception.Message);
        var setting = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        await context.HttpContext.Response.WriteAsJsonAsync(result, typeof(BaseResult), setting);
        context.ExceptionHandled = true;
    }
}