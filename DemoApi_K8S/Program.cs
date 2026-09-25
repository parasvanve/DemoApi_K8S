var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from Kubernetes - Version 4! Hello-------------------------------------------everyone ";
    
});

app.MapGet("/home", () =>
{
    return "Hello from Kubernetes -  ";

});

app.MapGet("/about", () =>
{
    return "Hello from about";
    
});

app.MapGet("/health", () =>
{
    return "Healthy";
});

app.Run();
