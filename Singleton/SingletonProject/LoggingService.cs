using SingletonProject.Singleton;

namespace SingletonProject
{
    public class LoggingService
    {
        public  static void Log(string message)
        {
            var config = ConfigurationManagerSingleton.Instance;
            var logLevel = config.GetSetting("LogLevel");
            Console.WriteLine($"[LoggingService] [{logLevel}] {message}");
        }
    }
}
