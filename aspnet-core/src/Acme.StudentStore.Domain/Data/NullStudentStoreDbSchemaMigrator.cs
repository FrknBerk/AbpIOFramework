using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentStore.Data
{
    /* This is used if database provider does't define
     * IStudentStoreDbSchemaMigrator implementation.
     */
    public class NullStudentStoreDbSchemaMigrator : IStudentStoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}