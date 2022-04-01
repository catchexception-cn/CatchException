using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CatchException.Data;
using Volo.Abp.DependencyInjection;

namespace CatchException.EntityFrameworkCore;

public class EntityFrameworkCoreCatchExceptionDbSchemaMigrator
    : ICatchExceptionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCatchExceptionDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CatchExceptionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CatchExceptionDbContext>()
            .Database
            .MigrateAsync();
    }
}
