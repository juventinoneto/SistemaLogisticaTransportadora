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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Cargo.Infrastructure;
using Cargo.Repository.Classes.ControleColetaDefinicaoCarga;
using Cargo.Repository.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Interfaces.ControleColetaDefinicaoCarga;
using Cargo.ApplicationService.Classe.ControleColetaDefinicaoCarga;
using AutoMapper;
using Cargo.ApplicationService.Classe.ControleExpedicao;
using Cargo.ApplicationService.Interfaces.ControleExpedicao;
using Cargo.Repository.Classes.ControleExpedicao;
using Cargo.Repository.Interfaces.ControleExpedicao;

namespace WebAPI
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
            services.AddDbContext<CargoContexto>(options => 
                options.UseSqlServer(Configuration["Data:CargoDB:ConnectionString"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(swagger =>
	        {
		        swagger.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Cargo API" });
	        });
            
            services.AddAutoMapper();
            
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColetaAppService, ColetaAppService>();
            services.AddScoped<IColetaRepository, ColetaRepository>();
            services.AddScoped<IParceiroRepository, ParceiroRepository>();
            services.AddScoped<IExpedicaoAppService, ExpedicaoAppService>();
            services.AddScoped<IExpedicaoRepository, ExpedicaoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
	        app.UseSwaggerUI(c =>
	        {
		        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cargo API");
	        });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
