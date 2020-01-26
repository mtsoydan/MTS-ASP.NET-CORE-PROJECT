using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.DependencyInjection;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.AspMvcCoreUI.Middlewares;
using MTS.Northwind.Business.Concrete;
using MTS.Northwind.DataAccess.Abstract;
using MTS.Northwind.DataAccess.Concrete.EntityFrameWork;
using MTS.Northwind.AspMvcCoreUI.Services;
using MTS.Northwind.AspMvcCoreUI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;

namespace MTS.Northwind.AspMvcCoreUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartService,CartService >();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //DbContext sınıfları için sql yolunu veriyoruz 
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Northwind;Trusted_Connection=true"));
            //Identity kullanmak için -->AddEntityFrameWorkstore için customIdentityDb context veriyoruz DefaultTOken kullanıcı verilerini sayfalar arası taşır
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSession();
            services.AddDistributedMemoryCache();



            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //use.staticFiles();
            //Yerine use file server kullanabiliriz
            app.UseFileServer();
            //App
#pragma warning disable CS0618 // Type or member is obsolete
            app.UseIdentity();
#pragma warning restore CS0618 // Type or member is obsolete
                              //extension methodumuza env içindeki root u gönderip konfigrasyonu tamamlıyoruz
            app.UseSession();
            app.UseNodeModules(env.ContentRootPath);
            app.UseMvc(configureRoutes);
        }

        private void configureRoutes(IRouteBuilder obj)
        {
            obj.MapRoute("Default", "{controller=Product}/{action=Index}/{id?}");
        }
    }
}
