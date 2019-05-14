using System;

using CacheService.Services;
using CacheService.Entity;

namespace CacheService.Cachusecasedi.Usecase
{
    class CachUseCase: ICachUseCase
    {
        private ICachService service = null;

        public CachUseCase(ICachService service)
        {
            this.service = service;
        }

        public bool AddToCache(string key, Value value)
        {
            return service.Set(key, value);
        }

        public bool AddToCache(Guid key, Value value)
        {
            return service.Set(key, value);
        }

        public Value GetFromCache(string key)
        {
            return service.Get(key);
        }

        public Value GetFromCache(Guid key)
        {
            return service.Get(key);
        }
    }
}
