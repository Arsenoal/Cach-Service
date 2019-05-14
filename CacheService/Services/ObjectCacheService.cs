using System;
using System.Runtime.Caching;
using CacheService.Entity;

namespace CacheService.Services
{
    class ObjectCacheService : ICachService
    {
        private ObjectCache objectCache;

        private ObjectCacheService () { objectCache = MemoryCache.Default; }

        public Value Get(string key)
        {
            return (Value)objectCache.Get(key);
        }

        public Value Get(Guid key)
        {
            return (Value)objectCache.Get(key.ToString());
        }

        public bool Set(Guid key, Value value)
        {
            return Set(key.ToString(), value);
        }

        public bool Set(string key, Value value)
        {   
            try {
                objectCache[key] =  value;
                return true;
            } catch(Exception e)
            {
                //TODO maybe log something
                return false;
            }
        }

        public static ObjectCacheService Instance { get { return ObjectCacheServiceProvider.instance; } }

        private class ObjectCacheServiceProvider
        {
            static ObjectCacheServiceProvider() { }

            internal static readonly ObjectCacheService instance = new ObjectCacheService();
        }
    }
}
