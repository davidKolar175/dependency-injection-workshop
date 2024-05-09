namespace Lifetime.Api;

public class IdGenerator
{
    public string ID { get; } = Guid.NewGuid().ToString();
}
