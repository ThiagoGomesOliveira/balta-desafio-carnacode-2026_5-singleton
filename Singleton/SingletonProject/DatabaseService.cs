using SingletonProject.Singleton;

namespace SingletonProject
{
    public class DatabaseService
    {
        public static void Connect()
        {
            var config = ConfigurationManagerSingleton.Instance;
            var connectionString = config.GetSetting("DatabaseConnection");
            Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
        }
    }
}
