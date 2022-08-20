using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    public static class ConnectionString
    {
        public static string Get(string name = "MsSQLServer", string path = "../WebAPI", string jsonPath = "appsettings.json")
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), path));
            configurationManager.AddJsonFile(jsonPath);

            return configurationManager.GetConnectionString(name);
        }
    }
}
