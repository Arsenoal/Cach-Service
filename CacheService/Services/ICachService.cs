using CacheService.Services;
using System;
using CacheService.Entity;

namespace CacheService.Services
{
    public interface ICachService
    {
        bool Set(Guid key, Value value);

        bool Set(string key, Value value);

        Value Get(string key);

        Value Get(Guid key);
    }
}
