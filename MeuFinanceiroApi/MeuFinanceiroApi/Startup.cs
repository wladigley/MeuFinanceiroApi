using MeuFinanceiroApi.Data;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Services;
using MeuFinanceiroApi.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace MeuFinanceiroApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<DataBaseParameters>();

            //DataBaseParameters 
            var envModel = Configuration.Get<DataBaseParameters>();
            services.AddTransient<ConnectionFactory>(ConnectionFactory => new ConnectionFactory(envModel.Server, envModel.DataBase, envModel.User, envModel.Password));

            services.AddTransient<IDespesasRepository, DespesasRepository>();

            services.AddTransient<IDespesasServices, DespesasServices>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Meu Financeiro",
                    Description = "Registro das despesas e receitas.",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Wladigley Simão",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/Wladigley"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MeuFinanceiroAPI V1");
                c.RoutePrefix = "swagger";
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
