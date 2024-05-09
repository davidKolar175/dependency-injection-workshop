namespace BackgroundServicesExamples;

public class Worker : BackgroundService
{
    private readonly ILogger<WorkerHostedLifecycle> _logger;

    public Worker(ILogger<WorkerHostedLifecycle> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
