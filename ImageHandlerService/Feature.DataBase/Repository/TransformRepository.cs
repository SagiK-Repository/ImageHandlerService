using Core.UseCase.DBService.Repository;
using Feature.DataBase.Context;

namespace Feature.DataBase.Repository;

public class TransformRepository : ITransformRepository
{
    private readonly ImageHandlerDBContext _imageHandlerDBContext;

    public TransformRepository(ImageHandlerDBContext imageHandlerDBContext)
    {
        _imageHandlerDBContext = imageHandlerDBContext;
    }
}
