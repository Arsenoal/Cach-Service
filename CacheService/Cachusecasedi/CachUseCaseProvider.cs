using System.Collections.Generic;
using CacheService.Services;
using CacheService.Cachusecasedi.Usecase;

namespace CacheService.Cachusecasedi
{
    public class CachUseCaseProvider
    {
        private CachUseCaseProvider() { }

        public ICachUseCase GetUseCase(ICachService service)
        {
            return UseCaseFactory.GetUseCase(UseCaseType.DEFAULT, service);
        }

        private ICachUseCase GetUseCase(UseCaseType type, ICachService service)
        {
            return UseCaseFactory.GetUseCase(type, service);
        }

        public static CachUseCaseProvider Instance { get { return UseCaseNestedProvider.instance; } }

        private class UseCaseNestedProvider {
            static UseCaseNestedProvider() { }

            internal static readonly CachUseCaseProvider instance = new CachUseCaseProvider();
        }
    }
}
