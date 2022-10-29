using ConsoleCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Classes
{
    class Car : Vehicle, ICar
    {
        public int NumberOfWheels { get; set; }

        private ILogger<Car> _logger;

        public Car(IVehicleDataReader dataReader) : base(dataReader) 
        {
            SetLogger();
        }

        public Car(IVehicleDataReader dataReader, string color): base (dataReader, color) 
        {
            SetLogger();
        }

        public Car(IVehicleDataReader dataReader, string color, string year): base (dataReader, color, year) 
        {
            SetLogger();
        }

        public Car(IVehicleDataReader dataReader, string color, string year, int numberOfWheels): this(dataReader, color, year)
        {
            NumberOfWheels = numberOfWheels;
        }

        public void Break()
        {
            _logger.LogInformation("Breaks!!!"); ;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Wheels: {NumberOfWheels}";
        }

        private void SetLogger()
        {
            _logger = (new ServiceCollection()
                .AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Debug))
                .BuildServiceProvider())
                    .GetService<ILoggerFactory>()
                    .CreateLogger<Car>();
        }
    }
}
