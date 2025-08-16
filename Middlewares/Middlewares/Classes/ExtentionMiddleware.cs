using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Middlewares.Classes;

public static class ExtentionMiddleware
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<MyMiddleware>();
    }
}
