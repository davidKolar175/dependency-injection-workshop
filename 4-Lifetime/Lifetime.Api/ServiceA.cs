namespace Lifetime.Api;

public class ServiceA
{
    private readonly IdGenerator _idGenerator;

    public ServiceA(IdGenerator idGenerator)
    {
        _idGenerator = idGenerator;
    }

    public string GetIDFromService() => _idGenerator.ID;
}
