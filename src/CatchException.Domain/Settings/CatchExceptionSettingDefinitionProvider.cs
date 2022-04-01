using Volo.Abp.Settings;

namespace CatchException.Settings;

public class CatchExceptionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CatchExceptionSettings.MySetting1));
    }
}
