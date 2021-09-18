using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ekitap.business.Abstract;
using ekitap.business.Concrete;
using ekitap.data.Abstract;
using ekitap.data.Concrete.EfCore;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace ekitap.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IkitapRepository,EfCorekitapRepository>();
            services.AddScoped<IkategoriRepository,EfCorekategoriRepository>();
            services.AddScoped<IyazarRepository,EfCoreyazarRepository>();

            services.AddScoped<IkitapService,kitapManager>(); 
            services.AddScoped<IkategoriService,kategoriManager>(); 
            services.AddScoped<IyazarService,yazarManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   

            app.UseStaticFiles(); // wwwroot

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"                
            });
           



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseRouting();


            //--varsayılan route
            app.UseEndpoints(endpoints =>
            {   

                
             

                //admin-kitap listeleme:
                endpoints.MapControllerRoute(
                    name: "adminkitaplist", 
                    pattern: "admin/kitaplar",
                    defaults: new {controller="Admin",action="KitapList"}
                );

                //--admin-kitap güncelleme:
                 endpoints.MapControllerRoute(
                    name: "adminkitapgüncelle", 
                    pattern: "admin/kitaplar/{id?}",
                    defaults: new {controller="Admin",action="KitapEdit"}
                );



                //--admin katerogi listeleme:
                endpoints.MapControllerRoute(
                    name: "adminkategorilist", 
                    pattern: "admin/kategoriler/list",
                    defaults: new {controller="Admin",action="KategoriList"}
                );

                //--kategori ekle:
                endpoints.MapControllerRoute(
                    name: "adminkategoriekle", 
                    pattern: "admin/kategoriler/ekle",
                    defaults: new {controller="Admin",action="KategoriEkle"}
                );

                //--kategori düzenle:
                endpoints.MapControllerRoute(
                    name: "adminkategoriEdit", 
                    pattern: "admin/kategoriler/edit/{id?}",
                    defaults: new {controller="Admin",action="KategoriEdit"}
                );

                //--kategori sil:
                endpoints.MapControllerRoute(
                    name: "adminkategoriDelete", 
                    pattern: "admin/kategoriler/sil/{id?}",
                    defaults: new {controller="Admin",action="KategoriDelete"}
                );

             

                //--kitap arama:
                endpoints.MapControllerRoute(
                    name:"kitapara",
                    pattern:"ara",
                    defaults:new{controller="ekitapislem",action="kitapara"}
                );   

              

                //kategoriye göre kitap filtreleme.
                
                endpoints.MapControllerRoute(
                    name:"kitaplar",
                    pattern:"kitaplar/{kategori?}",
                    defaults:new{controller="ekitapislem",action="list"}
                );

                //--ürün detay route:
                 endpoints.MapControllerRoute(
                    name:"kitapdetay",
                    pattern:"{url}",
                    defaults:new{controller="ekitapislem",action="details"}
                );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{kategori?}"
                );

                 //yazar list:
                endpoints.MapControllerRoute(
                    name:"adminyazarlist",
                    pattern:"admin/yazarlar/list",
                    defaults:new{controller="admin",action="YazarList"}
                );

                 //yazar ekle:

                endpoints.MapControllerRoute(
                    name:"adminyazarekle",
                    pattern:"admin/yazarlar/ekle",
                    defaults:new{controller="admin",action="YazarEkle"}
                );

                //--yazar-edit:
                 endpoints.MapControllerRoute(
                    name:"adminyazaredit",
                    pattern:"admin/yazarlar/edit/{id?}",
                    defaults:new{controller="admin",action="YazarEdit"}
                );







              
            });
        }
    }
}
