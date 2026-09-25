var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from Kubernetes - Version 4! Hello-------------------------------------------everyone ";
    
});

app.MapGet("/home", () =>
{
    return "Hello from Home -  ";

});

app.MapGet("/Dashboard", () =>
{
    return "Hello from Dashboard -  ";

});

app.MapGet("/about", () =>
{
    return "Hello from about";
    
});

app.MapGet("/health", () =>
{
    return "Hello from Healthy";
});

app.Run();
