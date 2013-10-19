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
            // This is required when not using Microsoft.Owin's AppBuilder
            // http://katanaproject.codeplex.com/workitem/81
            Microsoft.Owin.Infrastructure.SignatureConversions.AddConversions(app);

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
