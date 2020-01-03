using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MTS.Northwind.AspMvcCoreUI.Middlewares
{
    public static class ApplicationBuilderExtentions
    {
        //modullerimizi yöneteceğimiz extension modulü yazıyoruz
        //Extend ettiğimiz kısmı this olarak buraya yazmalıyız
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root)
        {
            var path = Path.Combine(root, "node_modules");
            //providea ihtiyac var statik dosyaları taşımaok adına kullanıla ara servis nesnesi
            var provider = new PhysicalFileProvider(path);

            //statik dosya sunumumu tanımlıyoruz
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = provider;
            app.UseStaticFiles(options);

            return app;
            

        }
    }
}
