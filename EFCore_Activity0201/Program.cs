using Microsoft.Extensions.Configuration;

namespace EFCore_Activity0201;
internal class Program
{
    private static IConfigurationRoot? _configuration;

    static void Main(string[] args)
    {
        BuildConfiguration();
        Console.WriteLine($"CNSTR: {_configuration.GetConnectionString("AdventureWorks")}");
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true,
            reloadOnChange: true);
        _configuration = builder.Build();
    }
}