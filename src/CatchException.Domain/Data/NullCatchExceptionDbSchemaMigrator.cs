using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CatchException.Data;

/* This is used if database provider does't define
 * ICatchExceptionDbSchemaMigrator implementation.
 */
public class NullCatchExceptionDbSchemaMigrator : ICatchExceptionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
