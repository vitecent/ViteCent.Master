/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using YPHF.Core.Data;

#endregion

namespace YPHF.Core.Api.Swagger;

/// <summary>
/// </summary>
public static class SwaggerExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="services"></param>
    /// <param name="title"></param>
    /// <param name="xmls"></param>
    /// <returns></returns>
    public static IServiceCollection AddSwagger(this IServiceCollection services, string title, List<string> xmls)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = title, Version = "v1" });
            foreach (var xml in xmls)
            {
                var path = Path.Combine(AppContext.BaseDirectory, $"{xml}.xml");
                options.IncludeXmlComments(path, true);
            }

            options.OrderActionsBy(x => x.RelativePath);

            options.AddSecurityDefinition("Token", new OpenApiSecurityScheme
            {
                Description = "请输入Token",
                Name = Const.Token,
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Token"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });

        return services;
    }

    /// <summary>
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static IApplicationBuilder UseSwaggerDashboard(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }
}