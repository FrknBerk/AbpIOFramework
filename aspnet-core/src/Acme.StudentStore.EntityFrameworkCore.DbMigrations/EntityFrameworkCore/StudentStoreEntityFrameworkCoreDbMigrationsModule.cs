using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.StudentStore.EntityFrameworkCore
{
    [DependsOn(
        typeof(StudentStoreEntityFrameworkCoreModule)
        )]
    public class StudentStoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StudentStoreMigrationsDbContext>();
        }
    }
}
