using Acme.StudentStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.StudentStore
{
    [DependsOn(
        typeof(StudentStoreEntityFrameworkCoreTestModule)
        )]
    public class StudentStoreDomainTestModule : AbpModule
    {

    }
}