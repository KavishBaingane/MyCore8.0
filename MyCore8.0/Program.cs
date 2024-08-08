var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{

    if (context.Request.Method == "GET")
    {
        context.Response.Headers["Content-Type"] = "text/html";
        if (context.Request.Headers.ContainsKey("User-Agent"))
        {
            string userAgent = context.Request.Query["User-Agent"];
            await context.Response.WriteAsync($"<p>{userAgent}</p>");
        }
    }
   
    
});

app.Run();
