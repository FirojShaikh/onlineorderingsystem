using Akka.Actor;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PlaceOrder.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static ActorSystem OrderPlacingActorSystem;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            OrderPlacingActorSystem = ActorSystem.Create("OrderPlacingActorSystem");
        }
    }
}
