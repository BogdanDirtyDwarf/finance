var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/test", () =>
{
    return Results.Json(new { text = "Hello world!" });
})
.WithName("GetHelloMessage");

app.Run();
