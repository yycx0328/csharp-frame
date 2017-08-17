using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Log;

namespace WebSite
{
    public class LogConfig
    {
        public static void Register()
        {
            LogHelper.InitLog4net();   
        }
    }
}