using CatchException.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CatchException.Permissions;

public class CatchExceptionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CatchExceptionPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CatchExceptionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CatchExceptionResource>(name);
    }
}
