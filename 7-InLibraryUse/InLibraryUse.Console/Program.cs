using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

// Často se lze setkat s takovýmto zápisem, který přidává do DI nějakou funkčnost (controllery, swagger, logging, ...)
serviceCollection.AddAmazingService();

var serviceProvider = serviceCollection.BuildServiceProvider();
