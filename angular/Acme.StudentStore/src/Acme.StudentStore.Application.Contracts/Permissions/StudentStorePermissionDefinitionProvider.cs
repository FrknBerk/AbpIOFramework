using Acme.StudentStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentStore.Permissions
{
    public class StudentStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StudentStorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StudentStorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StudentStoreResource>(name);
        }
    }
}
