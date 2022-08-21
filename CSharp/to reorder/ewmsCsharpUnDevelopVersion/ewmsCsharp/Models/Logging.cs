using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp;
using ewmsCsharp.Classes;
using ewmsCsharp.Models;

namespace ewmsCsharp.Models
{
    public class Logging
    {

        private static ServiceProvider _serviceProvider = new ServiceCollection()
                    .AddLogging(configuration =>
                        {
                        configuration.AddConsole();
                        configuration.SetMinimumLevel(LogLevel.Debug);
                        })
                    // .AddSingleton<IVehicleDataReader, VehicleDataReader>()
                    .BuildServiceProvider();

        public static ILogger<object> setLogger<T>()
                => (ILogger<object>)_serviceProvider.GetService<ILoggerFactory>()
                        .CreateLogger <T> ();

    }
}
