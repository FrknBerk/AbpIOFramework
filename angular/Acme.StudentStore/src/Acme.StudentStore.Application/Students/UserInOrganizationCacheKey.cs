using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StudentStore.Students
{
    public class UserInOrganizationCacheKey
    {
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }

        public override string ToString()
        {
            return $"{UserId}_{OrganizationId}";
        }
    }
}
