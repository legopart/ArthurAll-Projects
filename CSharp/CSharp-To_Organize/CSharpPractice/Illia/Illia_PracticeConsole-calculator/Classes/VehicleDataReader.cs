using ConsoleCalculator.Interfaces;
using ConsoleCalculator.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Classes
{
    class VehicleDataReader : IVehicleDataReader
    {
        private ILogger<VehicleDataReader> _logger;

        public VehicleDataReader()
        {
            _logger = (new ServiceCollection()
                .AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Debug))
                .BuildServiceProvider())
                    .GetService<ILoggerFactory>()
                    .CreateLogger<VehicleDataReader>();
        }

        public int GetMileage()
        {
            AppData appData;
            using (StreamReader reader = new StreamReader("C:/TEMP/console-calculator/ConsoleCalculator/Data/data.json"))
            {
                string json = reader.ReadToEnd();
                appData = JsonConvert.DeserializeObject<AppData>(json);
            }

            if (int.TryParse(appData.data.mileage, out int mileage))
            {
                return mileage;
            }
            else
            {
                throw new Exception("Mileage in the file is not a parsable number");
            }
        }
    }
}
