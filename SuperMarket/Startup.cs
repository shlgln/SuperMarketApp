using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SuperMarket.Models;
using SuperMarket.Repositories.RepositoryGood;
using SuperMarket.Repositories.RepositoryGoodCategory;
using SuperMarket.Repositories.RepositoryGoodEntry;
using SuperMarket.Repositories.RepositorySalesFactor;
using SuperMarket.UnitOfWorks;

namespace SuperMarket
{
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
            services.AddSwaggerGen();
            services.AddScoped<ApplicationContex>();
            services.AddScoped<GoodCategoryRepository, EFGoodCateroty>();
            services.AddScoped<UnitOfWork, EFUnitOfWork>();
            services.AddScoped<GoodRepository, EFGood>();
            services.AddScoped<SalesFactorRepository, EFSalesFactor>();
            services.AddScoped<GoodEntryRepository, EFGoodEntry>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
