var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from Kubernetes - Version 4!";
     return "Hello-------------------------------------------everyone";
});

app.MapGet("/health", () =>
{
    return "Healthy";
});

app.Run();
