using ResolvingServices.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<IFormService, FormService>(); // Demostrovat i resolvnutí IEnumerable
builder.Services.AddSingleton<IFormRepository, FormRepository>();
builder.Services.AddKeyedSingleton("first", new HashGenerator("first"));
builder.Services.AddKeyedSingleton("second", new HashGenerator("second"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
