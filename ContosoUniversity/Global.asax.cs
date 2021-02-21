using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ContosoUniversity.DAL;//added
using System.Data.Entity.Infrastructure.Interception;//added

namespace ContosoUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //These lines of code are what causes your interceptor code to be run 
            //when Entity Framework sends queries to the database. 
            //Notice that because you created separate interceptor classes for 
            //transient error simulation and logging, you can independently enable and disable them.

            DbInterception.Add(new SchoolInterceptorTransientErrors());//added
            DbInterception.Add(new SchoolInterceptorLogging());//added

        }
    }
}
