using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CatchException;

[Dependency(ReplaceServices = true)]
public class CatchExceptionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CatchException";
}
