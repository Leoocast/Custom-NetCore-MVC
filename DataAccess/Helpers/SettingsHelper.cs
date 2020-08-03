using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Helpers
{
    internal class SettingsHelper
    {
        public IConfigurationSection GetSettings(string section)
        {
            var configBuilder = new ConfigurationBuilder();
            var json = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(json, false);

            var settings = configBuilder.Build();

            return settings.GetSection(section);
        }
    }
}
