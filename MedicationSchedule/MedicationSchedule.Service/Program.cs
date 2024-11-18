using MedicationSchedule.Service.IoC;

var builder = WebApplication.CreateBuilder(args);

SerilogConfigurator.ConfigureService(builder);
SwaggerConfigurator.ConfigureServices(builder);
DbContextConfigurator.ConfigureServices(builder);
MapperConfigurator.ConfigureServices(builder);
ServicesConfigurator.ConfigureServices(builder);

builder.Services.AddControllers();

var app = builder.Build();

SerilogConfigurator.ConfigureApplication(app);
SwaggerConfigurator.ConfigureApplication(app);
DbContextConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();