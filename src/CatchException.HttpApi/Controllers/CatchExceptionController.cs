using CatchException.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CatchException.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CatchExceptionController : AbpControllerBase
{
    protected CatchExceptionController()
    {
        LocalizationResource = typeof(CatchExceptionResource);
    }
}
