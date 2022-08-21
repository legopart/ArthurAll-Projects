using ConsoleCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleCalculator.Classes
{
    /// <summary>
    /// This is my great vehicle object that will raise me $1M
    /// </summary>
    public class Vehicle : Object, IVehicle
    {
        #region Public members
        /// <summary>
        /// This would be the color of my vehicle and that's it
        /// </summary>
        public string Color
        {
            get
            {
                return GetFormattedColor();
            }

            set
            {
                _color = SetUppercaseColor(value);
            }
        }

        // public string Color { get; set; }
        #endregion

        public int Year { get; }

        public int Mileage { get; private set; }

        #region Private members
        private ILogger<Vehicle> _logger;

        private string _color;
        private int _year;
        #endregion

        #region Constructors
        /// <summary>
        /// This constructor whil create a vehicle with default color
        /// </summary>
        public Vehicle(IVehicleDataReader dataReader) 
        {
            _logger = (new ServiceCollection()
                .AddLogging(console => console.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Debug))
                .BuildServiceProvider())
                    .GetService<ILoggerFactory>()
                    .CreateLogger<Vehicle>();

            Color = "default";
            _year = 2000;

            try
            {
                Mileage = dataReader.GetMileage();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        /// <summary>
        /// Another one
        /// </summary>
        /// <param name="color">The color you like for your vehicle</param>
        public Vehicle(IVehicleDataReader dataReader, string color) : this(dataReader)
        {
            _color = SetUppercaseColor(color);
        }

        public Vehicle(IVehicleDataReader dataReader, string color, string year) : this(dataReader, color)
        {
            if (!int.TryParse(year, out _year)) 
            {
                _logger.LogWarning("Year provided is not a number");
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Method
        /// </summary>
        /// <param name="param">param 1</param>
        /// <returns>Something</returns>
        public string SomeFunction(string param)
        {
            _logger.LogInformation("Hi");
            return "";
        }

        public void MoveForward()
        {
            Mileage++;
            _logger.LogInformation($"I'm moving towards {Mileage}");
        }

        #region Overrides
        public override string ToString()
        {
             return $"Year: {_year}, {GetFormattedColor()}";
        }
        #endregion
        #endregion

        #region Private methods
        private string GetFormattedColor()
        {
            return $"Color: {_color}";
        }

        private string SetUppercaseColor(string color)
        {
            return color.ToUpper();
        }
        #endregion
    }

}
