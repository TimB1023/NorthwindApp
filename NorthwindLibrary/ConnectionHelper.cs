﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLibrary
{
    public static class ConnectionHelper
    {
        public static string CnnVal(string name)
        {
            // Gets connection string from the App.config file (needs to be added - see OneNote on this project)
            // Discovered that the App.Config is only in .NET Framework. 
            var Output = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return Output;
        }
    }
}
