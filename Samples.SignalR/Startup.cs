using Owin;
using Microsoft.AspNet.SignalR;

using Samples.SignalR.Connections;

namespace Samples.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            var config = new HubConfiguration();
            config.EnableJavaScriptProxies = true;
            config.EnableDetailedErrors = true;

            //builder.MapConnection<ChatConnection>("/chat");
            builder.MapSignalR(config);
        }
    }
}
