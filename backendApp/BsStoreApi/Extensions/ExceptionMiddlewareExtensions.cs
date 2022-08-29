using Entities.ErrorModel;
using Entities.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace BsStoreApi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appErr => appErr.Run(async context =>
            {
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    context.Response.StatusCode = contextFeature.Error switch
                    {
                        NotFoundException => StatusCodes.Status404NotFound,
                          _=> StatusCodes.Status500InternalServerError,

                    };
                    await context.Response.WriteAsync(new ErorrDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        StatusMessage = contextFeature.Error.Message
                    }.ToString());
                }
            }));
        }
    }
}
