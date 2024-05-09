using BackgroundServicesExamples;

var builder = WebApplication.CreateBuilder(args);

// IHostedService vs. BackgroundService vs. IHostedLifecycleService
// AddHostedService je jedin� metoda pro p�id�n�

builder.Services.AddHostedService<Worker>();
//builder.Services.AddHostedService<WorkerHosted>();
//builder.Services.AddHostedService<WorkerHostedLifecycle>();

//builder.Services.Configure<HostOptions>(x =>
//{
//    x.ServicesStartConcurrently = true;
//    x.ServicesStopConcurrently = true;
//});

var app = builder.Build();
app.Run();

