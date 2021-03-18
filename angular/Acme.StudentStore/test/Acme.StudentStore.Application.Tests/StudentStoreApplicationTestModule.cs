using Volo.Abp.Modularity;

namespace Acme.StudentStore
{
    [DependsOn(
        typeof(StudentStoreApplicationModule),
        typeof(StudentStoreDomainTestModule)
        )]
    public class StudentStoreApplicationTestModule : AbpModule
    {

    }
}