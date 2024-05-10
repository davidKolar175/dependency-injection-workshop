using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

var serviceCollection = new ServiceCollection();

// Různé způsoby, jak přidat singleton službu
serviceCollection.AddSingleton<UserService>();
serviceCollection.AddSingleton<IUserService, UserService>();
serviceCollection.AddSingleton(serviceProvider => new UserService());
serviceCollection.AddSingleton<IUserService>(serviceProvider => new UserService());
serviceCollection.Add(new ServiceDescriptor(typeof(IUserService), typeof(UserService), ServiceLifetime.Singleton));

// Mutace přidávání
//serviceCollection.TryAddSingleton<IUserService, UserService>();
//serviceCollection.AddKeyedSingleton<IUserService, UserService>("klíč_123");
//serviceCollection.TryAddKeyedSingleton<IUserService, UserService>("klíč_123");
//serviceCollection.TryAddEnumerable(new ServiceDescriptor(typeof(IUserService), typeof(UserService2), ServiceLifetime.Singleton));

// Rozdílnost chování TryAdd A TryAddEnumerable
//serviceCollection.TryAdd(new ServiceDescriptor(typeof(IUserService), typeof(UserService2), ServiceLifetime.Singleton));
//serviceCollection.TryAddEnumerable(new ServiceDescriptor(typeof(IUserService), typeof(UserService2), ServiceLifetime.Singleton));
//serviceCollection.TryAddEnumerable([
//    new ServiceDescriptor(typeof(IUserService), typeof(UserService), ServiceLifetime.Singleton),
//    new ServiceDescriptor(typeof(IUserService), typeof(UserService2), ServiceLifetime.Singleton)
//]);

var serviceProvider = serviceCollection.BuildServiceProvider(); // Sestavení stromu závislostí

var userService = serviceProvider.GetRequiredService<IUserService>();
//var userService = serviceProvider.GetKeyedService<IUserService>("klíč_123");


Console.WriteLine(userService.GetUser());


public class UserService : IUserService
{
    public string GetUser() => "David Kolář";
}

public class UserService2 : IUserService
{
    public string GetUser() => "Kolář David";
}

public interface IUserService
{
    string GetUser();
}
