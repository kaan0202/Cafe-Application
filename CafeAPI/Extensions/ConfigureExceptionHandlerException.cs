using Application.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text.Json;

namespace CafeAPI.Extensions
{
    public static class ConfigureExceptionHandlerException
    {
        public static void ConfigureExceptionHandler(this WebApplication builder)
        {
            builder.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    var statusCode = contextFeature.Error switch
                    {
                        ClientSideException => 400,
                        BadRequestException => 502,
                        UnAuthorizedException => 401,
                        InternalServerException => 500,
                        NotFoundException => 404
                    };

                    context.Response.StatusCode = statusCode;

                    if(contextFeature!= null)
                    {
                        await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            StatusCode = statusCode,
                            Message = contextFeature.Error.Message,
                            Title = "Hata alındı"
                        }));
                    }
                    
                });
            }
                );
        }
    }
}
