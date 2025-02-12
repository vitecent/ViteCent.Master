﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Template.Core.Data;

namespace Template.Core.Authorize.Jwt;

/// <summary>
/// </summary>
public class BaseJwt
{
    /// <summary>
    /// </summary>
    /// <param name="user"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public string GenerateJwtToken(BaseUserInfo user, IConfiguration configuration)
    {
        var logger = BaseLogger.GetLogger();

        var key = configuration["Jwt:Key"] ?? default!;

        if (string.IsNullOrWhiteSpace(key)) throw new Exception("Appsettings Must Be Jwt:Key");

        logger.Info($"Jwt Key ：{key}");

        var issuer = configuration["Jwt:Issuer"] ?? default!;

        if (string.IsNullOrWhiteSpace(issuer)) throw new Exception("Appsettings Must Be Jwt:Issuer");

        logger.Info($"Jwt Issuer ：{issuer}");

        var audience = configuration["Jwt:Audience"] ?? default!;

        if (string.IsNullOrWhiteSpace(audience)) throw new Exception("Appsettings Must Be Jwt:Audience");

        logger.Info($"Jwt Audience ：{audience}");

        var flagExpires = int.TryParse(configuration["Jwt:Expires"] ?? default!, out var expires);

        if (!flagExpires || expires < 1) expires = 24;

        logger.Info($"Jwt Expires ：{expires}");

        var claims = new[]
        {
            new Claim(ClaimTypes.UserData, user.ToJson())
        };

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer,
            audience,
            claims,
            expires: DateTime.Now.AddHours(expires),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}