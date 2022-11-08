using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TestWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        static IBusControl _busControl;

        public static IBus ApplicationBus
        {
            get { return _busControl; }
        }
        protected void Application_Start()
        {
            _busControl = ConfigureBus();
            _busControl.Start();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
        protected void Application_End()
        {
            _busControl.Stop(TimeSpan.FromSeconds(10)); ;
        }
        IBusControl ConfigureBus()
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });
            });
        }

    }
}
