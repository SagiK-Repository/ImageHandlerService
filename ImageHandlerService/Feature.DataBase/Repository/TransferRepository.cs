using Core.UseCase.DBService.Repository;
using Feature.DataBase.Context;

namespace Feature.DataBase.Repository;

public class TransferRepository : ITransferRepository
{
    private readonly ImageHandlerDBContext _imageHandlerDBContext;

    public TransferRepository(ImageHandlerDBContext imageHandlerDBContext)
    {
        _imageHandlerDBContext = imageHandlerDBContext;
    }
}
