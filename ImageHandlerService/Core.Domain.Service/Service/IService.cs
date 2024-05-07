﻿using Core.Domain.ValueObject;

namespace Core.Domain.Service;

public interface IService
{
    ID Id { get; }
    List<ImageGroup> ImageGroups { get; }
}
