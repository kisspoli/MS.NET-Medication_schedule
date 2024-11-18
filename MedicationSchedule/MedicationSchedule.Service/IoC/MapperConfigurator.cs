using MedicationSchedule.BL.Mappers;

namespace MedicationSchedule.Service.IoC;

public class MapperConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(config =>
        {
            config.AddProfile<UsersBLProfile>();
            config.AddProfile<RolesBLProfile>();
            config.AddProfile<PlansBLProfile>();
        });
    }
}