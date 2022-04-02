using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CatchException.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CatchExceptionDbContextFactory : IDesignTimeDbContextFactory<CatchExceptionDbContext>
{
    public CatchExceptionDbContext CreateDbContext(string[] args)
    {
        CatchExceptionEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        //var builder = new DbContextOptionsBuilder<CatchExceptionDbContext>()
        //    .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);
        var builder = new DbContextOptionsBuilder<CatchExceptionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new CatchExceptionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CatchException.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
