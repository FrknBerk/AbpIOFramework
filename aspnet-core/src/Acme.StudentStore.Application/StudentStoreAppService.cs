using System;
using System.Collections.Generic;
using System.Text;
using Acme.StudentStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentStore
{
    /* Inherit your application services from this class.
     */
    public abstract class StudentStoreAppService : ApplicationService
    {
        protected StudentStoreAppService()
        {
            LocalizationResource = typeof(StudentStoreResource);
        }
    }
}
