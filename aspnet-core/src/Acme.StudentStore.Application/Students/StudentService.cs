using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentStore.Students
{
    public class StudentService : ITransientDependency
    {
        private readonly IDistributedCache<StudentCacheItem, Guid> _cache;

        public StudentService(IDistributedCache<StudentCacheItem, Guid> cache)
        {
            _cache = cache;
        }

        public async Task<StudentCacheItem> GetAsync(Guid studentId) 
        { 
            return await _cache.GetOrAddAsync(
                studentId,
                async () => await GetStudentFromDatabaseAsync(studentId),
                () => new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = DateTimeOffset.Now.AddHours(1)
                });
        }

        private Task<StudentCacheItem> GetStudentFromDatabaseAsync(Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}
