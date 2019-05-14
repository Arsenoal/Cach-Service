using System;
using System.Collections.Generic;
using System.Text;
using CacheService.Services;

namespace CacheService.Cachusecasedi.Usecase
{
    class UseCaseFactory
    {
        public static ICachUseCase GetUseCase(UseCaseType type, ICachService service)
        {
            switch(type)
            {
                case UseCaseType.DEFAULT:
                    return new CachUseCase(service);
                default:
                    return new CachUseCase(service);
            }
        }
    }
}
