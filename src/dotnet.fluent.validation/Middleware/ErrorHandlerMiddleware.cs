using FluentValidation;
using Newtonsoft.Json;
using System.Net;

namespace dotnet.fluent.validation.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                switch (error)
                {
                    case ValidationException e:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var values = JsonConvert.DeserializeObject<string[]>(error.Message);

                await response.WriteAsync(new ErrorDetails()
                {
                    Errors = values

                }.ToString());
            }
        }
    }
}
