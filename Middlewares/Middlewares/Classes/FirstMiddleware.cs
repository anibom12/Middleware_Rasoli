namespace Middlewares.Classes;

public class FirstMiddleware
{
    private readonly RequestDelegate next;
    public FirstMiddleware (RequestDelegate next)
    {
        this.next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("<p>Welcome to first middleware</p> ");
        await next(context);
    }
}
