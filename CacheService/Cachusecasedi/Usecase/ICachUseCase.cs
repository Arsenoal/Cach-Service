using System;
using CacheService.Entity;

namespace CacheService.Cachusecasedi.Usecase
{
    public interface ICachUseCase
    {
        bool AddToCache(string key, Value value);

        bool AddToCache(Guid key, Value value);
        
        Value GetFromCache(string key);

        Value GetFromCache(Guid key);
    }
}
