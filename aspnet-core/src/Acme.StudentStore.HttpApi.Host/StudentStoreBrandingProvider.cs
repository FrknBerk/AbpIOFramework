using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.StudentStore
{
    [Dependency(ReplaceServices = true)]
    public class StudentStoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "StudentStore";
    }
}
