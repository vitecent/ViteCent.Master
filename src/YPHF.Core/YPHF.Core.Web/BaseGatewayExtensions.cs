/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YPHF.Core.Web
{
    /// <summary>
    /// Class BaseGatewayExtensions.
    /// </summary>
    public static class BaseGatewayExtensions
    {
        /// <summary>
        /// Adds the consul.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection AddGateway(this IServiceCollection services)
        {
            services.AddHttpClient();

            return services;
        }

        /// <summary>
        /// Uses the gateway.
        /// </summary>
        /// <param name="app">The app.</param>
        /// <returns>IApplicationBuilder.</returns>
        public static void UseGateway(this WebApplication app)
        {
            app.UseMiddleware<BaseGateway>();
        }
    }
}