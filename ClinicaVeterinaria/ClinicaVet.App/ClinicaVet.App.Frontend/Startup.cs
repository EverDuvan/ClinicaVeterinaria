using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVet.App.Persistencia;
using ClinicaVet.App.Persistencia.AppRepositorio;
using ClinicaVet.App.Dominio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ClinicaVet.App.Frontend
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
            services.AddRazorPages(
                options => {
                    options.Conventions.AuthorizeFolder("/Menu");
                    /*
                    options.Conventions.AuthorizeFolder("/Menu/Auxiliares");
                    options.Conventions.AuthorizeFolder("/Menu/Clientes");
                    options.Conventions.AuthorizeFolder("/Menu/Consultas");
                    options.Conventions.AuthorizeFolder("/Menu/Historias");
                    options.Conventions.AuthorizeFolder("/Menu/Mascotas");
                    options.Conventions.AuthorizeFolder("/Menu/Veterinarios");
                    */

                    options.Conventions.AuthorizePage("/Index");
                    options.Conventions.AllowAnonymousToPage("/Privacy");
                }
            );
            Contexto _contexto = new Contexto();
            services.AddSingleton<IRepositorioDueño>(new RepositorioDueño(_contexto));
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(_contexto));
            services.AddSingleton<IRepositorioConsulta>(new RepositorioConsulta(_contexto));
            services.AddSingleton<IRepositorioVeterinario>(new RepositorioVeterinario(_contexto));
            services.AddSingleton<IRepositorioAgenda>(new RepositorioAgenda(_contexto));
            services.AddSingleton<IRepositorioMascota>(new RepositorioMascota(_contexto));
            services.AddSingleton<IRepositorioHistoriaClinica>(new RepositorioHistoriaClinica(_contexto));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Conference}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
