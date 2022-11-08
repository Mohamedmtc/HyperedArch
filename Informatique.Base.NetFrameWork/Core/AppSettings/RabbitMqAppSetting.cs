using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatique.Base.NetFrameWork.Core.AppSettings
{
    public class RabbitMqAppSetting : ConfigurationSection
    {
        [ConfigurationProperty("OnPrem")]
        public RabbitMqConfiguration OnPrem
        {
            get
            {
                return (RabbitMqConfiguration)this["OnPrem"];
            }
            set
            {
                value = (RabbitMqConfiguration)this["OnPrem"];
            }
        }
        [ConfigurationProperty("AmazonMq")]
        public RabbitMqConfiguration AmazonMq
        {
            get
            {
                return (RabbitMqConfiguration)this["AmazonMq"];
            }
            set
            {
                value = (RabbitMqConfiguration)this["AmazonMq"];
            }
        }
        [ConfigurationProperty("Enable", DefaultValue = true, IsRequired = true)]
        public bool Enable {
            get
            {
                return (bool)this["Enable"];
            }
            set
            {
                value = (bool)this["Enable"];
            }
        }
        [ConfigurationProperty("RabbitMqBusClientType", DefaultValue = "OnPrem", IsRequired = true)]
        public string RabbitMqBusClientType
        {
            get
            {
                return (string)this["RabbitMqBusClientType"];
            }
            set
            {
                value = (string)this["RabbitMqBusClientType"];
            }
        }
    }

    public class RabbitMqConfiguration : ConfigurationElement
    {
        [ConfigurationProperty("HostName", DefaultValue = "localhost", IsRequired = true)]
        public string HostName { get; set; }
        [ConfigurationProperty("UserName", DefaultValue = "Guest", IsRequired = true)]
        public string UserName { get; set; }
        [ConfigurationProperty("Password", DefaultValue = "Guest", IsRequired = true)]
        public string Password { get; set; }
    }

    public class RabbitMqBusClientType 
    {
        public const string OnPrem = "OnPrem";
        public const string AmazonMq = "AmazonMq";

    }
}
