using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Caching;

namespace Acme.StudentStore
{
    [DependsOn(
        typeof(StudentStoreDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(StudentStoreApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    [DependsOn(typeof(AbpCachingModule))]
    public class StudentStoreApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<StudentStoreApplicationModule>();
            });
            Configure<AbpDistributedCacheOptions>(options =>
            {
                options.KeyPrefix = "MyApp";
            });
        }
    }
}
