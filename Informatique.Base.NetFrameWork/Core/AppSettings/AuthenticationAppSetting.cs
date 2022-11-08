using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatique.Base.NetFrameWork.Core.AppSettings
{
    public class AuthenticationAppSetting : ConfigurationSection
    {
        [ConfigurationProperty("Jwt")]
        public Jwt Jwt
        {
            get
            {
                return (Jwt)this["Jwt"];
            }
            set
            {
                value = (Jwt)this["Jwt"];
            }
        }
    }

    public class Jwt : ConfigurationElement
    {
        [ConfigurationProperty("secretKey", DefaultValue = "", IsRequired = true)]
        public string secretKey
        {
            get
            {
                return (string)this["secretKey"];
            }
            set
            {
                value = (string)this["secretKey"];
            }
        }
        [ConfigurationProperty("expiryMinutes", DefaultValue = 00000, IsRequired = true)]
        public int expiryMinutes {
            get
            {
                return (int)this["expiryMinutes"];
            }
            set
            {
                value = (int)this["expiryMinutes"];
            }
        }
    }
}
