using System.Threading.Tasks;

namespace CatchException.Data;

public interface ICatchExceptionDbSchemaMigrator
{
    Task MigrateAsync();
}
