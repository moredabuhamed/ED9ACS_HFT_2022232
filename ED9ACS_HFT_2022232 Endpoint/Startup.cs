using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ED9ACS_HFT_2022232_Endpoint.services;
using ED9ACS_HFT_2022232_Logic;
using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ED9ACS_HFT_2022232_Repository;

namespace ED9ACS_HFT_2022232_Endpoint
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            ////services.AddControllersWithViews().AddNewtonsoftJson(options =>
            ////                                      options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<IFansLogic, FansLogic>();
            services.AddTransient<IArtistsLogic, ArtistsLogic>();
            services.AddTransient<IReservationsLogic, ReservationsLogic>();
            services.AddTransient<IReservationsServicesLogic, ReservationsServicesLogic>();
            services.AddTransient<IServicesLogic, ServicesLogic>();
            services.AddTransient<IRepository<Fans>, FansRepository>();
            services.AddTransient<IRepository<Artists>, ArtistsRepository>();
            services.AddTransient< IRepository< Reservations>, ReservationsRepository>();
            services.AddTransient<IRepository<ReservationsServices>, ReservationsServicesRepository>();

            services.AddTransient<IRepository<Services>, ServicesRepository>();
            services.AddTransient<TalkWithYourFavoriteArtistDbContext, TalkWithYourFavoriteArtistDbContext>();
            services.AddSignalR();


        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(x => x
                .AllowCredentials()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithOrigins("http://localhost:23079"));

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SignalRHub>("/hub");
            });
        }
    }
}
