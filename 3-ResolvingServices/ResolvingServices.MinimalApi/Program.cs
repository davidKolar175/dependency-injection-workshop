using ResolvingServices.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IFormService, FormService>();
builder.Services.AddSingleton<IFormRepository, FormRepository>();
builder.Services.AddKeyedSingleton("first", new HashGenerator("first"));
builder.Services.AddKeyedSingleton("second", new HashGenerator("second"));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/form", (IFormService formService, ILogger<FormService> logger) =>
{
    logger.LogInformation(formService.GetForm());
});

app.Run();
