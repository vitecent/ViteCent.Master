/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using YPHF.Core.Data;
using YPHF.Core.Enums;

#endregion

namespace YPHF.Core.Web.Filter;

/// <summary>
/// </summary>
public class SupperAuthFilter : ActionFilterAttribute
{
    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        dynamic controller = context.Controller;
        var logger =
            context.HttpContext.RequestServices.GetService(
                typeof(ILogger<BaseAuthFilter>)) as ILogger<BaseAuthFilter> ?? default!;

        var user = controller?.User;

        if (user == null)
        {
            logger.LogWarning($"{user?.Name} InvokeAsync No Auth");
            context.Result = new JsonResult(new BaseResult(401, "您没有权限访问该数据"));

            return;
        }

        if (user?.IsSuperAdmin == (int)YesNoEnum.No)
        {
            logger.LogWarning($"{user.Name} InvokeAsync No Auth");
            context.Result = new JsonResult(new BaseResult(401, "您没有权限访问该数据"));

            return;
        }

        logger.LogInformation($"{user?.Name} InvokeAsync Auth");
    }

    /// <summary>
    /// </summary>
    /// <param name="user"></param>
    /// <param name="system"></param>
    /// <param name="resource"></param>
    /// <param name="operation"></param>
    /// <returns></returns>
    private static bool IsAUth(BaseUserInfo user, string system, string resource, string operation)
    {
        var _system = user.Auth.FirstOrDefault(x => x.Code == system);
        if (_system != null)
        {
            var _resource = _system.Resources.FirstOrDefault(x => x.Code == resource);
            if (_resource != null)
            {
                var _operation = _resource.Operations.FirstOrDefault(x => x.Code == operation);
                if (_operation != null) return true;
            }
        }

        return false;
    }
}