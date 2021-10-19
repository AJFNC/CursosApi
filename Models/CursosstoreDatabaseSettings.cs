
namespace CursosApi.Models
{
    public class CursosstoreDatabaseSettings : ICursostoreDatabaseSettings
    {
        public string CursosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICursostoreDatabaseSettings
    {
        string CursosCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
