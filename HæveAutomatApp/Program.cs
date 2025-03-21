using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HæveAutomatApp.Interfaces.Controller;
using HæveAutomatApp.Controllers;
using HæveAutomatApp.Interfaces;

namespace Hæveautomaten
{
    public static class Program
    {
        public static void Main()
        {
            ServiceProvider serviceProvider = ConfigureServices();

            using (IServiceScope scope = serviceProvider.CreateScope())
            {
            }
        }

        private static ServiceProvider ConfigureServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IUserController, UserController>();
            serviceCollection.AddSingleton<ICreditCardController, CreditCardController>();
            serviceCollection.AddSingleton<IAccountController, AccountController>();

            // TODO: Add the actual connection string
            //serviceCollection.AddDbContext<HæveautomatenDbContext>(options => options.UseSqlite("Data Source=Hæveautomaten.db"));

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}