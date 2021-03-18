using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StudentStore.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentStore.EntityFrameworkCore
{
    public class EntityFrameworkCoreStudentStoreDbSchemaMigrator
        : IStudentStoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreStudentStoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the StudentStoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<StudentStoreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}