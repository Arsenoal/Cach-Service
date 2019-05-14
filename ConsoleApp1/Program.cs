using CacheService.Cachusecasedi;
using CacheService.Cachusecasedi.Usecase;
using CacheService.Services;
using CacheService.Entity;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CachUseCaseProvider provider = CachUseCaseProvider.Instance;
            ICachService service = CachServiceFactory.GetService(CachServiceType.DEFAULT);

            ICachUseCase useCase = provider.GetUseCase(service);
            Value value = new Value("data");
            useCase.AddToCache(key: "key", value: value);

            Value resValue = useCase.GetFromCache(key: "key");

            Console.Write("data is: " + resValue.data);

            value = new Value("data updated");
            useCase.AddToCache(key: "key", value: value);

            resValue = useCase.GetFromCache(key: "key");

            Console.Write("\n");
            Console.Write("data is: " + resValue.data);
        }
    }
}