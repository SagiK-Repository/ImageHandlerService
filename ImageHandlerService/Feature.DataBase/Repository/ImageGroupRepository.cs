using Core.UseCase.DBService.Repository;
using Feature.DataBase.Context;

namespace Feature.DataBase.Repository;

public class ImageGroupRepository : IImageGroupRepository
{
    private readonly ImageHandlerDBContext _imageHandlerDBContext;

    public ImageGroupRepository(ImageHandlerDBContext imageHandlerDBContext)
    {
        _imageHandlerDBContext = imageHandlerDBContext;
    }
}
