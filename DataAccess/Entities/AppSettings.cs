using DataAccess.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataAccess.Entities
{
    internal class AppSettings
    {
        private string Server { get; set; }
        private string Database { get; set; }
        private string User { get; set; }
        private string Pass { get; set; }

        public string GetConectionString() => 
              $@"Server={Server}
                ;Database={Database}
                ;User Id={User}
                ;Password={Pass}
                ;";

        public AppSettings() {

            var settings = new SettingsHelper().GetSettings("AppSettings");

            Server = settings["Server"];
            Database = settings["Database"];
            User = settings["User"];
            Pass = settings["Pass"];
        }

    }
}
