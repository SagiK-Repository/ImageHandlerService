using Core.UseCase.DB.Repository;
using Feature.DataBase.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DBService.Extension;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IDBServiceRepository, DBServiceRepository>();
        services.AddScoped<IImageGroupRepository, ImageGroupRepository>();
        services.AddScoped<ITransferRepository, TransferRepository>();
        services.AddScoped<ITransformRepository, TransformRepository>();
        return services;
    }
}
