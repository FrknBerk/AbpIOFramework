using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;

namespace Acme.StudentStore.Students
{
    [CacheName("Students")]
    public class StudentCacheItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

    }
}
