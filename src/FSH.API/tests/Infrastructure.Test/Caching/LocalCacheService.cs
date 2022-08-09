using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;

namespace Infrastructure.Test.Caching;

public class LocalCacheService : CacheService<FSH.API.Infrastructure.Caching.LocalCacheService>
{
    protected override FSH.API.Infrastructure.Caching.LocalCacheService CreateCacheService() =>
        new(
            new MemoryCache(new MemoryCacheOptions()),
            NullLogger<FSH.API.Infrastructure.Caching.LocalCacheService>.Instance);
}