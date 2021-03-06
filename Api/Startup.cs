using EloyAhora.BLL;
using EloyAhora.DAL;
using EloyAhora.Entities;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Api
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

            services.AddControllers().AddNewtonsoftJson();
            services.AddOData();
            
            services.Configure<EloyAhoraDatabaseSettings>(
                Configuration.GetSection(nameof(EloyAhoraDatabaseSettings)));

            services.AddSingleton<IEloyAhoraDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<EloyAhoraDatabaseSettings>>().Value);



            services.AddSingleton<IProductService ,ProductService>();
            services.AddSingleton<IProductRepository,ProductRepository>();

            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();

            services.AddSingleton<ITagService, TagService>();
            services.AddSingleton<ITagRepository, TagRepository>();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().Filter().Expand();
                endpoints.MapControllers();
            });
        }
    }
}
