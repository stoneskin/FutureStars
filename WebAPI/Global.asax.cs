using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAPI
{
    using Microsoft.AspNet.SignalR;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //enable cross domain for SignalR
            var hubConfiguration = new HubConfiguration { EnableCrossDomain = true };
            RouteTable.Routes.MapHubs(hubConfiguration);
           // RouteTable.Routes.MapHubs();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }

        public static void RegisterRoutes(RouteCollection routes)
        {
        }
    }
}