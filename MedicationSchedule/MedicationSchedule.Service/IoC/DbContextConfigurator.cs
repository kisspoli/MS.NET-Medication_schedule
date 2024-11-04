using MedicationSchedule.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace MedicationSchedule.Service.IoC;

public class DbContextConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
        var connectionString = configuration.GetConnectionString("MedicationScheduleDbContext");

        builder.Services.AddDbContextFactory<MedicationScheduleDbContext>(
            options => { options.UseNpgsql(connectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<MedicationScheduleDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}