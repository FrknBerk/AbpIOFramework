using Acme.StudentStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.StudentStore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StudentStoreEntityFrameworkCoreDbMigrationsModule),
        typeof(StudentStoreApplicationContractsModule)
        )]
    public class StudentStoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
