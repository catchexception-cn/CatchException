using System;
using System.Collections.Generic;
using System.Text;
using CatchException.Localization;
using Volo.Abp.Application.Services;

namespace CatchException;

/* Inherit your application services from this class.
 */
public abstract class CatchExceptionAppService : ApplicationService
{
    protected CatchExceptionAppService()
    {
        LocalizationResource = typeof(CatchExceptionResource);
    }
}
