using SingletonProject.Singleton;

namespace SingletonProject
{
    public class CacheService
    {
        public static void Connect()
        {
            var config = ConfigurationManagerSingleton.Instance;
            var cacheServer = config.GetSetting("CacheServer");
            Console.WriteLine($"[CacheService] Conectando ao cache: {cacheServer}");
        }
    }
}
