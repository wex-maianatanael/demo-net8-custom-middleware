namespace Demo.CustomMiddleware.CustomMiddleware
{
    public class IncomingHttpRequestsCustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<IncomingHttpRequestsCustomMiddleware> _logger;

        public IncomingHttpRequestsCustomMiddleware(RequestDelegate next, ILogger<IncomingHttpRequestsCustomMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Logic before passing to the next middleware (e.g., request logging)
            _logger.LogInformation($"[Request] {context.Request.Method} {context.Request.Path}");

            await _next(context); // Pass the request to the next middleware

            // Logic after the next middleware has processed the request (e.g., response logging)
            _logger.LogInformation($"[Response] Status Code: {context.Response.StatusCode}");
        }
    }
}
