using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloHttp
{
    public static class Config
    {
        public static readonly String Url = ConfigurationManager.AppSettings["Url"];
    }
}
