using Api.Data.Context;
using Data.Repository;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            //services.AddScoped(ICustomerRepository, CustomerRepository)();
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Data Source=DELL-CLASSIC;Database=NORTHWND;User ID=sa; Password=classic1*; Trusted_Connection=True; TrustServerCertificate=True;")
            );
        }
    }
}
