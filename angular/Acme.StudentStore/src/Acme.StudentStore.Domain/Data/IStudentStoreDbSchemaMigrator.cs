using System.Threading.Tasks;

namespace Acme.StudentStore.Data
{
    public interface IStudentStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
