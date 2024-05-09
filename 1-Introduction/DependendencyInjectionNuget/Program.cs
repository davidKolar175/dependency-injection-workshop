using DependencyInjectionNuget;
using Microsoft.Extensions.DependencyInjection;

// DI se netýká pouze Web api!
// Pořadí následujících kódu je důležité!

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IUserService, UserService>();

var serviceProvider = serviceCollection.BuildServiceProvider(); // Sestavení stromu závislostí

var userService = serviceProvider.GetRequiredService<IUserService>(); // Existují různé způsoby konzumace, bude ještě probráno.

Console.WriteLine(userService.GetUser());
