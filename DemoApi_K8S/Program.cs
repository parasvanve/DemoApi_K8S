var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from  Kubernetes!";
});

app.MapGet("/health", () =>
{
    return "Healthy";
});

app.Run();