using SingletonProject.Singleton;

namespace SingletonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Configurações ===\n");

            Console.WriteLine("Inicializando serviços...\n");
            
            Console.WriteLine("\nUsando os serviços...\n");

            DatabaseService.Connect();
            ApiService.MakeRequest();
            CacheService.Connect();
            LoggingService.Log("Sistema iniciado");

            Console.WriteLine("\n--- Tentativa de atualização ---\n");
            
            var config1 = ConfigurationManagerSingleton.Instance;
            config1.LoadConfigurations();
            config1.UpdateSetting("LogLevel", "Debug");

            var config2 = ConfigurationManagerSingleton.Instance;
            config2.LoadConfigurations();
            Console.WriteLine($"Config1 LogLevel: {config1.GetSetting("LogLevel")}");
            Console.WriteLine($"Config2 LogLevel: {config2.GetSetting("LogLevel")}");
            
            Console.WriteLine("utilizando singleton");
        }
    }
}
