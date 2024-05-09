namespace BackgroundServicesExamples;

/// Vhodné, pokud používáme konkurentní inicializaci služeb na pozadí a potøebujeme nìkteré kroky udìlat pøed StartAsync
public class WorkerHostedLifecycle : IHostedLifecycleService
{
    private readonly ILogger<WorkerHostedLifecycle> _logger;

    public WorkerHostedLifecycle(ILogger<WorkerHostedLifecycle> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Start_start");
        await Task.Delay(5000, cancellationToken);
        _logger.LogInformation("Start_end");
    }

    public async Task StartedAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Started_start");
        await Task.Delay(5000, cancellationToken);
        _logger.LogInformation("Started_end");
    }

    // Užiteèné tøeba pro inicializaci DB
    public async Task StartingAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting_start");
        await Task.Delay(5000, cancellationToken);
        _logger.LogInformation("Starting_end");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
