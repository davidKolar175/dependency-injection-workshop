using Microsoft.Extensions.Logging;

namespace ResolvingServices.Shared;

public class FormRepository : IFormRepository
{
    private readonly ILogger<FormRepository> _logger;

    public FormRepository(ILogger<FormRepository> logger)
    {
        _logger = logger;
    }

    public string GetForm()
    {
        _logger.LogInformation("Loading from database...");
        return "FRM.CFormular.CFormular";
    }
}
