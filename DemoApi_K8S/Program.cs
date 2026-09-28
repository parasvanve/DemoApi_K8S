var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from Kubernetes - Version 4! Hello-------------------------------------------e ";
    
});

app.MapGet("/home", () =>
{
    return "Hello from Home -  ";

});

app.MapGet("/version", () =>
{
    return "Hello from version -  ";

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
