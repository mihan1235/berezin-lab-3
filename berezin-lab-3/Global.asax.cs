using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Libs;

namespace berezin_lab_3
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static DataBase db { get; } = new DataBase();
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
