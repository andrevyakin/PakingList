using Microsoft.Extensions.DependencyInjection;
using PakingList.Services.Interfaces;

namespace PakingList.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<IDataService, DataService>()
           .AddTransient<IUserDialog, UserDialog>()
        ;
    }
}
