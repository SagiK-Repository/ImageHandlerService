using Core.UseCase.DBService.Repository;
using Feature.DataBase.Context;

namespace Feature.DataBase.Repository;

public class DBServiceRepository : IDBServiceRepository
{
    private readonly ImageHandlerDBContext _imageHandlerDBContext;

    public DBServiceRepository(ImageHandlerDBContext imageHandlerDBContext)
    {
        _imageHandlerDBContext = imageHandlerDBContext;
    }   
}
