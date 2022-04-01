using CatchException.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CatchException.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CatchExceptionEntityFrameworkCoreModule),
    typeof(CatchExceptionApplicationContractsModule)
    )]
public class CatchExceptionDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
