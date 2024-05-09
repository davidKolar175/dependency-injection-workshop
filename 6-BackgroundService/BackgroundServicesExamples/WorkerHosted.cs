namespace BackgroundServicesExamples;

public class WorkerHosted : IHostedService
{
    private readonly ILogger<WorkerHostedLifecycle> _logger;

    public WorkerHosted(ILogger<WorkerHostedLifecycle> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Start_start");
        await Task.Delay(5000, cancellationToken);
        _logger.LogInformation("Start_end");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("End_start");
        await Task.Delay(5000, cancellationToken);
        _logger.LogInformation("End_end");
    }
}
