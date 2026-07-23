using System.Diagnostics;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Log request
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");

            await _next(context);

            stopwatch.Stop();
            // Log response
            Console.WriteLine($"[Response] {context.Response.StatusCode} in {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
