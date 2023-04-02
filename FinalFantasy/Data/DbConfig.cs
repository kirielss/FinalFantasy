namespace FinalFantasy.Data
{
    static public class DbConfig
    {
        static private readonly IConfiguration _configuration;

        static DbConfig()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        static public string ConnectionString => _configuration.GetConnectionString("DefaultConnection");
    }
}
