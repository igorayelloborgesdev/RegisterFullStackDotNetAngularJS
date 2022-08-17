using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace APIFuncionario.Config
{
    public static class AppConfig
    {
        private static string connStr;
        public static string GetConnStr()
        {
            if (connStr == null)
            {
                connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            }
            return connStr;
        }
    }
}