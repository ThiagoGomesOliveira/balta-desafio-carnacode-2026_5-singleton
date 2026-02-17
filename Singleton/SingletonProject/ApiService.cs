using SingletonProject.Singleton;

namespace SingletonProject
{
    public class ApiService
    {
        public static void MakeRequest()
        {
            var config = ConfigurationManagerSingleton.Instance;
            var apiKey = config.GetSetting("ApiKey");
            Console.WriteLine($"[ApiService] Fazendo requisição com API Key: {apiKey}");
        }
    }
}
