using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(CatchExceptionApplicationModule),
    typeof(CatchExceptionDomainTestModule)
    )]
public class CatchExceptionApplicationTestModule : AbpModule
{

}
