using Middlewares.Classes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProblemDetails();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}
app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<p>Welcome to Third Middleware</p>");
    await next();
    await context.Response.WriteAsync("<p>Welcome back</p>");

});

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/hi"))
    {
        await context.Response.WriteAsync("Hiiii");
    }
    await next();
});


app.UseMyMiddleware();
app.UseMiddleware<FirstMiddleware>();

app.UseStaticFiles();



app.Run();
