using Microsoft.Extensions.DependencyInjection;

namespace ResolvingServices.Shared;

public class FormService : IFormService
{
    private readonly IFormRepository _formRepository;
    private readonly HashGenerator _hashGenerator;

    public FormService(IFormRepository formRepository, [FromKeyedServices("second")] HashGenerator hashGenerator)
    {
        _formRepository = formRepository;
        _hashGenerator = hashGenerator;
    }

    public string GetForm()
    {
        return _hashGenerator.GetNewHash() + _formRepository.GetForm();
    }
}
