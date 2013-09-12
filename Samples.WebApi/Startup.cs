using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using Owin;
using Samples.WebApi.Config;

namespace Samples.WebApi
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
