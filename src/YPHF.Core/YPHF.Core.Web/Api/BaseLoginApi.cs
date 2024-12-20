/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Http;
using YPHF.Core.Cache;
using YPHF.Core.Data;

namespace YPHF.Core.Web.Api
{
    /// <summary>
    /// </summary>
    /// <typeparam name="Args"></typeparam>
    /// <typeparam name="Result"></typeparam>
    public abstract class BaseLoginApi<Args, Result> : BaseApi<Args, Result>
        where Args : BaseArgs
        where Result : BaseResult
    {
        /// <summary>
        /// </summary>
        private readonly IBaseCache cache;

        /// <summary>
        /// </summary>
        public BaseLoginApi()
        {
            var context = BaseHttpContext.Context;
            cache = context.RequestServices.GetService(typeof(IBaseCache)) as IBaseCache ?? default!;
        }

        /// <summary>
        /// </summary>
        public string Token
        {
            get
            {
                var token = HttpContext.Request.Headers[Const.Token];

                if (!string.IsNullOrWhiteSpace(token))
                {
                    return token.ToString();
                }

                return default!;
            }
        }

        /// <summary>
        /// </summary>
        public new BaseUserInfo User
        {
            get
            {
                var token = Token;
                if (!string.IsNullOrWhiteSpace(token))
                {
                    if (cache.HasKey(token))
                    {
                        var auth = cache.GetString<BaseUserInfo>(token);
                        if (auth != null)
                        {
                            cache.SetKeyExpire(auth.Id, new TimeSpan(8, 0, 0));
                            cache.SetKeyExpire(token, new TimeSpan(8, 30, 0));

                            return auth;
                        }
                        else
                        {
                            cache.DeleteKey(token);
                        }
                    }
                }

                return default!;
            }
        }
    }
}