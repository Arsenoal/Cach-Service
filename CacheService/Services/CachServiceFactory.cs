using System;
using System.Collections.Generic;
using System.Text;

namespace CacheService.Services
{
    public class CachServiceFactory
    {
        public static ICachService GetService(CachServiceType type)
        {
            switch(type)
            {
                case CachServiceType.DEFAULT:
                    return ObjectCacheService.Instance;
                default:
                    return ObjectCacheService.Instance;
            }
        }
    }
}
