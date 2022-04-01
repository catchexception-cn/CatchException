using CatchException.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(CatchExceptionEntityFrameworkCoreTestModule)
    )]
public class CatchExceptionDomainTestModule : AbpModule
{

}
