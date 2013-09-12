using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Samples.WebApi.Controllers
{
    public class HelloController : ApiController
    {
        // GET Api/Hello/World/
        [HttpGet]
        [ActionName("World")]
        public HttpResponseMessage HelloWorld()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.Content = new StringContent("Hello world!");
            response.Headers.CacheControl = new CacheControlHeaderValue();
            response.Headers.CacheControl.MustRevalidate = true;
            response.Headers.CacheControl.MaxAge = TimeSpan.Zero;
            response.Headers.CacheControl.Private = true;
            return response;
        }
    }
}
