namespace ResolvingServices.Shared;

public class HashGenerator
{
    private readonly string _salt;

    public HashGenerator(string salt)
    {
        _salt = salt;
    }

    public string GetNewHash() => _salt + Guid.NewGuid().ToString();
}
