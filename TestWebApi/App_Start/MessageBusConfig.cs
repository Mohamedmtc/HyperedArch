using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi.App_Start
{
    public class MessageBusConfig
    {
        public static IBusControl BusControl { get; set; }


        public static void Configure()
        {


            BusControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
               cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });


            });

            BusControl.Start();
        }
    }
}