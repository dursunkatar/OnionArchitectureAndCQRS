using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OnionArchitecture.Application;
using OnionArchitecture.Application.Features.ProductEntity.Commands.Create;
using OnionArchitecture.Infrastructure;
using OnionArchitecture.Infrastructure.Attributes;
using OnionArchitecture.Persistence;
using System.IO;

namespace OnionArchitecture.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddPersistenceServices(Configuration);
            services.AddInfrastructureServices();
            services.AddControllers(options => options.Filters.Add<ValidationFilter>())
                .AddFluentValidation(configuration => configuration
                    .RegisterValidatorsFromAssemblyContaining<CreateProductCommandValidator>())
                .ConfigureApiBehaviorOptions(o => o.SuppressModelStateInvalidFilter = true);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProductExample.WebAPI", Version = "v1" });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, $"ProductExample.WebAPI.xml");
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProductExample.WebAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
