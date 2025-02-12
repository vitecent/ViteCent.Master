/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Template.Core.Data;

#endregion

namespace Template.Core.Web.Filter;

/// <summary>
/// </summary>
public class BaseExceptionFilter : IExceptionFilter
{
    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    public async void OnException(ExceptionContext context)
    {
        var logger = BaseLogger.GetLogger();
        logger.Error(context.Exception.Message);

        var result = new BaseResult(500, context.Exception.Message);

        await context.HttpContext.Response.WriteAsJsonAsync(result, typeof(BaseResult), JsonSerializerOptions.Web);

        context.ExceptionHandled = true;
    }
}