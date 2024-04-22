﻿using Core.Domain.Service;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain.Transfer;

public class TransferInfo : Detail, IService
{
    public ID Id { get; set; } = new(0);

    public Dir SendDir { get; set; } = new(string.Empty);

    public List<ImageGroup> ImageGroups { get; set; } = [];
}
