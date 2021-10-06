using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
namespace simplemiddleware
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "simplemiddleware", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "simplemiddleware v1"));
            }
            app.Use(async (context, next) =>
            {
                // Do work that doesn't write to the Response.
                await context.Response.WriteAsync("Hello from 1st delegate.");
                await next.Invoke();
                // Do logging or other work that doesn't write to the Response.
            });

            app.Use(async (context,next1) =>
            {
                await context.Response.WriteAsync("Hello from 2nd delegate.");
                await next1.Invoke();
            });

            app.Run(async (context) =>
           {
               await context.Response.WriteAsync("Hello from 3rd delegate.");

           });
            
            app.Use(async (context,next2) =>
            {
                await context.Response.WriteAsync("Hello from 4rd delegate.");
                await next2.Invoke();

            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
