namespace Samples.Fix_SimpleWeb
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Fix;
    using Simple.Web;
    using Simple.Web.Behaviors;

    public class FixConfig
    {
        public Task Invoke(IDictionary<string, object> env)
        {
            Func<IDictionary<string, object>, Task> app = new Fixer().Use(Application.Run).Build();
            return app(env);
        }
    }

    [UriTemplate("/")]
    public class Index : IGet, IOutput<RawHtml>
    {
        public Status Get()
        {
            return 200;
        }

        public RawHtml Output
        {
            get { return "<h1>¡Hello World!</h1>"; }
        }
    }
}