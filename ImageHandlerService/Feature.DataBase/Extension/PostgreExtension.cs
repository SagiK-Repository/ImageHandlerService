using Feature.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Feature.DataBase.Extension;

public static class PostgreExtension
{
    public static IServiceCollection AddPostgreDBContext(this IServiceCollection services, ConfigurationManager configuration)
    {
        return services.AddDbContext<ImageHandlerDBContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("Core.UseCase.DBService")));
    }
}
