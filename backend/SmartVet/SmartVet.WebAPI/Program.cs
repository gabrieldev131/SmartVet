using SmartVet.Application;
using SmartVet.Application.Services;
using SmartVet.Infrastructure;
using SmartVet.Infrastructure.Context;
using SmartVet.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.AddConfiguration();
        builder.AddJwtAuthentication();

        //builder.AddServiceDefaults();
        // Add services to the container.
        builder.Services.ConfigurePersistenceApp(builder.Configuration);
        builder.Services.ConfigureApplicationServices();
        builder.Services.ConfigureApplicationApp();

        builder.Services.ConfigureCorsPolicy();

        builder.Services.ODataConfiguration();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartVet API", Version = "v1" });

            options.ResolveConflictingActions(x => x.First());

            options.CustomSchemaIds(type => type.ToString());
        });

        #region Adição do Serilog
        //Log.Logger = new LoggerConfiguration()
        //            .MinimumLevel.Debug()
        //            .WriteTo.Console()
        //            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
        //            .CreateLogger();
        //builder.Host.UseSerilog(Log.Logger);
        #endregion

        var app = builder.Build();

        CreateDatabase(app);

        //app.MapDefaultEndpoints();

        // Configure the HTTP Command pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors();

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();


        void CreateDatabase(WebApplication app)
        {
            var serviceScope = app.Services.CreateScope();
            var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
            dataContext?.Database.EnsureCreated();
            dataContext?.Database.Migrate();

            // Carga no banco de dados
            //var sqlFile = "./Scripts/inserts.sql";
            //var sql = File.ReadAllText(sqlFile);
            //dataContext?.Database.ExecuteSqlRaw(sql);
        }
    }
}