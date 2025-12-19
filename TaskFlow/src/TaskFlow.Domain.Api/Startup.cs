using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskFlow.Domain.Handlers;
using TaskFlow.Domain.Infra.Contexts;
using TaskFlow.Domain.Infra.Repositories;
using TaskFlow.Domain.Repositories;

namespace TaskFlow.Domain.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //Adicionando Injeção de dependencia para o DataContext

        services.AddDbContext<DataContext>(options =>
            options.UseInMemoryDatabase("TaskFlowDB"));
        services.AddTransient<ITodoRepository, TodoRepository>();
        services.AddTransient<TodoHandler, TodoHandler>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}