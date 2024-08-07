var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    string Path = context.Request.Path;
    string Method = context.Request.Method;


    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync($"<p>{Path}</p>");
    await context.Response.WriteAsync($"<p>{Method}</p>");
});

app.Run();
