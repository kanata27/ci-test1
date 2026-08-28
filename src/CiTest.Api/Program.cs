using CiTest.Api;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "ok"
    });
});

app.MapGet("/add", (int a, int b) =>
{
    return Results.Ok(new
    {
        result = Calculator.Add(a, b)
    });
});

app.Run();