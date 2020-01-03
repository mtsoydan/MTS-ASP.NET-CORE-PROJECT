using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.AspMvcCoreUI.Middlewares;
using MTS.Northwind.Business.Concrete;
using MTS.Northwind.DataAccess.Abstract;
using MTS.Northwind.DataAccess.Concrete.EntityFrameWork;

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
            //extension methodumuza env içindeki root u gönderip konfigrasyonu tamamlıyoruz

            app.UseNodeModules(env.ContentRootPath);
            app.UseMvcWithDefaultRoute();
        }
    }
}
