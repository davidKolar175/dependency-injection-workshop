using Lifetime.Api;

var builder = WebApplication.CreateBuilder(args);

// Zajímavá je kobinace transient a singletonu, musíme dávat pozor na zachycení instance
// Kombinace singleton a scoped padá, ukázat pøíklad AddScoped<IdGenerator> a AddSingleton<ServiceA>
// Circular dependency padá
// Závislost singletonu na transient je možná, ale bacha na možná neoèekávané chování

builder.Services.AddSingleton<IdGenerator>();
builder.Services.AddSingleton<ServiceA>();

var app = builder.Build();

app.UseHttpsRedirection();

// Pomocí spuštìní http souboru mùžeme otestovat
app.MapGet(
    "/id",
    (IdGenerator idGenerator, ServiceA serviceA) => $"IDGenerator: {idGenerator.ID}\nServiceA: {serviceA.GetIDFromService()}"
);

app.Run();
