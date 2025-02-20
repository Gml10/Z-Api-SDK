using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ZapiSdk
{
    public class ZApiConfigure
    {
        public string BaseUrl { get; set; } = "https://api.z-api.io/instances/";
        public string Instance { get; set; }
        public string Secret { get; set; }
        public string Token { get; set; }
    }
}
