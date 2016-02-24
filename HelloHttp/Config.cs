using System;
using System.Configuration;

namespace HelloHttp
{
    public static class Config
    {
        public static readonly String Url = ConfigurationManager.AppSettings["Url"];
    }
}
