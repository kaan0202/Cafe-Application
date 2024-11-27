using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CafeAPI.Extensions
{
    public static class JwtExtensions
    {
        public static void ConfigureJwt(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer("simple-cafe-app",options => {
                    options.TokenValidationParameters = new()
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidAudience = builder.Configuration["TokenOptions:Audience"],
                        ValidIssuer = builder.Configuration["TokenOptions:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenOptions:SecurityKey"])),
                        LifetimeValidator = (notBefore, expires, securityToken, validationParameters)
                   => expires != null ? expires > DateTime.UtcNow : false,
                    };
                });
        }
        }
    }

