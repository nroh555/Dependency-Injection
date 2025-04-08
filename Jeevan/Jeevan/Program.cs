using Microsoft.Extensions.DependencyInjection;

namespace Jeevan

{
    class Program
    {
        static void Main(string[] args)
        {
            // Transient means that everytime someone makes a request to IDeck interface, create a new instance of deck
            // What happens here is it pretty much maps the IDeck interface to the deck class
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IDeck, Deck>();
            serviceCollection.AddTransient<Jeevan>();
            
            var serviceProvider = serviceCollection.BuildServiceProvider();
            
            // The goal here is to show that for transient everytime you make a request to the interface or service
            // A brand new instance will be created but it is confined within the lifecycle of the application
            // For singleton, everytime you make a request to the interface or service
            // it will reuse the same instance but once again confined within the lifecycle of the application
            // There is also a thing call scoped but most useful for rest api based applications
            
            for (var i = 0; i < 10; i++)
            {
                var jeevan = serviceProvider.GetRequiredService<Jeevan>();
                var price = jeevan.GetPrice("Pokemon");
                Console.WriteLine($"Attempt {i + 1}: {price}");
            }
        }
    }
}