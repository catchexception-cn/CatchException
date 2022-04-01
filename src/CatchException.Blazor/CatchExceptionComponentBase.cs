using CatchException.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CatchException.Blazor;

public abstract class CatchExceptionComponentBase : AbpComponentBase
{
    protected CatchExceptionComponentBase()
    {
        LocalizationResource = typeof(CatchExceptionResource);
    }
}
