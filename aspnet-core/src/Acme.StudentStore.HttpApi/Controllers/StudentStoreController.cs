using Acme.StudentStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentStore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StudentStoreController : AbpController
    {
        protected StudentStoreController()
        {
            LocalizationResource = typeof(StudentStoreResource);
        }
    }
}