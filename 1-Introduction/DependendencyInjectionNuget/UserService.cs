namespace DependencyInjectionNuget;

internal class UserService : IUserService
{
    public string GetUser()
    {
        return "David Kolář";
    }
}
