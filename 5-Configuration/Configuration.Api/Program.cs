using Configuration.Api;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IServiceA, ServiceA>(serviceProvider =>
    new ServiceA(serviceProvider.GetRequiredService<IConfiguration>()["ConnectionString"]!));

// VS.

builder.Services.Configure<ComplexConfigurationOptions>(builder.Configuration.GetSection("ComplexConfigurationOptions"));





var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/config", (IConfiguration config, IServiceA a) =>
{
    var complexOptions = new ComplexConfigurationOptions();
    config.GetSection("ComplexConfigurationOptions").Bind(complexOptions);

    return complexOptions.VeryComplexString;
});

app.MapGet("/options", (IOptions<ComplexConfigurationOptions> config) =>
{
    return config.Value.VeryComplexString;
});

app.Run();
