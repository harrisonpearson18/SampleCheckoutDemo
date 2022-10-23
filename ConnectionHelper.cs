using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCheckoutApplicationDemo
{
    public static class ConnectionHelper
    {
        // Connection helper class to facilitate database connection string entry across the DataAccess class
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
