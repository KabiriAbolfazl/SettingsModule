using Microsoft.EntityFrameworkCore;
using SettingApi.Data;

namespace SettingApi.Services;

public static class AppConfiguration
{
    public static void AddEfCoreConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });
    }
}
