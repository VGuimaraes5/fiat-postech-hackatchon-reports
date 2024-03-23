using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Hackathon.Reports.Api.Infra.Configurations;

public static class AuthenticationConfig
{
    public static void AuthenticationConfigurations(this IServiceCollection servicesCollection, IConfiguration configuration)
    {
        servicesCollection.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            var poolId = configuration["Aws:PoolId"];

            options.Authority = $"https://cognito-idp.us-east-1.amazonaws.com/{poolId}";
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = $"https://cognito-idp.us-east-1.amazonaws.com/{poolId}",
                ValidateLifetime = true,
                LifetimeValidator = (before, expires, token, param) => expires > DateTime.UtcNow,
                ValidateAudience = false
            };
        });
    }
}