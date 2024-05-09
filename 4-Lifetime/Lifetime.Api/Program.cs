using Lifetime.Api;

var builder = WebApplication.CreateBuilder(args);

// Zaj�mav� je kobinace transient a singletonu, mus�me d�vat pozor na zachycen� instance
// Kombinace singleton a scoped pad�, uk�zat p��klad AddScoped<IdGenerator> a AddSingleton<ServiceA>
// Circular dependency pad�
// Z�vislost singletonu na transient je mo�n�, ale bacha na mo�n� neo�ek�van� chov�n�

builder.Services.AddSingleton<IdGenerator>();
builder.Services.AddSingleton<ServiceA>();

var app = builder.Build();

app.UseHttpsRedirection();

// Pomoc� spu�t�n� http souboru m��eme otestovat
app.MapGet(
    "/id",
    (IdGenerator idGenerator, ServiceA serviceA) => $"IDGenerator: {idGenerator.ID}\nServiceA: {serviceA.GetIDFromService()}"
);

app.Run();
