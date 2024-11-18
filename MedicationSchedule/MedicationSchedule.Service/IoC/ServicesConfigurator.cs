using AutoMapper;
using MedicationSchedule.BL.Plans.Manager;
using MedicationSchedule.BL.Plans.Provider;
using MedicationSchedule.BL.Roles.Manager;
using MedicationSchedule.BL.Roles.Provider;
using MedicationSchedule.BL.Users.Manager;
using MedicationSchedule.BL.Users.Provider;
using MedicationSchedule.DataAccess;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;

namespace MedicationSchedule.Service.IoC;

public class ServicesConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<IRepository<UserEntity>>(x => 
            new Repository<UserEntity>(x.GetRequiredService<IDbContextFactory<MedicationScheduleDbContext>>()));
        builder.Services.AddScoped<IUsersProvider>(x => 
            new UsersProvider(x.GetRequiredService<IRepository<UserEntity>>(), 
                x.GetRequiredService<IMapper>()));
        builder.Services.AddScoped<IUsersManager>(x =>
            new UsersManager(x.GetRequiredService<IRepository<UserEntity>>(),
                x.GetRequiredService<IMapper>()));
        
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<IRepository<PlanEntity>>(x => 
            new Repository<PlanEntity>(x.GetRequiredService<IDbContextFactory<MedicationScheduleDbContext>>()));
        builder.Services.AddScoped<IPlansProvider>(x => 
            new PlansProvider(x.GetRequiredService<IRepository<PlanEntity>>(), 
                x.GetRequiredService<IMapper>()));
        builder.Services.AddScoped<IPlansManager>(x =>
            new PlansManager(x.GetRequiredService<IRepository<PlanEntity>>(),
                x.GetRequiredService<IMapper>()));
        
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<IRepository<RoleEntity>>(x => 
            new Repository<RoleEntity>(x.GetRequiredService<IDbContextFactory<MedicationScheduleDbContext>>()));
        builder.Services.AddScoped<IRolesProvider>(x => 
            new RolesProvider(x.GetRequiredService<IRepository<RoleEntity>>(), 
                x.GetRequiredService<IMapper>()));
        builder.Services.AddScoped<IRolesManager>(x =>
            new RolesManager(x.GetRequiredService<IRepository<RoleEntity>>(),
                x.GetRequiredService<IMapper>()));
    }
}