namespace Middlewares.Classes;

public class MyMiddleware
{
    private readonly RequestDelegate next;
    public MyMiddleware(RequestDelegate next)
    {
        this.next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("<p>Welcome to my Middleware</p>");
        await next(context);

    }
}
