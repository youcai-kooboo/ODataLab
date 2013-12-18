using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using ProductService.Migrations;

namespace ProductService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var initial = new Initial();
            initial.Up();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
