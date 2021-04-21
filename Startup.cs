using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ElectronNET.API;  
using ElectronNET.API.Entities;  
using System.Runtime.InteropServices;

namespace CKS_1._0
{
    public class Startup
    {
        public async void ElectronBootstrap()
{
    var browserWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
    {
        Width = 1152,
        Height = 940,
        Show = true
    });
    await browserWindow.WebContents.Session.ClearCacheAsync();
    browserWindow.OnReadyToShow += () => browserWindow.Show();
    browserWindow.SetTitle("Combat Karts Management System");
}
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private async void CreateWindow()  
{  
    var window = await Electron.WindowManager.CreateWindowAsync();  
    window.OnClosed += () => {  
        Electron.App.Quit();

    };  
}





        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
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

                if (HybridSupport.IsElectronActive)  
{  
    ElectronBootstrap();  
}

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }

    
    
}


