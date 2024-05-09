using Microsoft.AspNetCore.Mvc;
using ResolvingServices.Shared;

namespace ResolvingServices.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FormController : ControllerBase
{
    private readonly IFormService _formService;

    public FormController(IFormService formService)
    {
        _formService = formService;
    }

    [HttpGet(Name = "form")]
    public string Get([FromServices] ILogger<FormController> logger)
    {
        logger.LogInformation(_formService.GetForm());
        return _formService.GetForm();
    }
}
