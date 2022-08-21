using ConsoleCalculator.Classes;
using ConsoleCalculator.Interfaces;
using ConsoleCalculator.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleCalculator
{
    class Program
    {
        private static ILogger<Program> _logger;
        private static ServiceProvider _serviceProvider;
        private static ApplicationStates _applicationState = ApplicationStates.Initializing;
        private static List<Fruit> _fruits = new List<Fruit>();

        static void Main(string[] args)
        {
            _serviceProvider = new ServiceCollection()
                .AddLogging(configuration =>
                {
                    configuration.AddConsole();
                    configuration.SetMinimumLevel(LogLevel.Debug);
                })
                .AddSingleton<IVehicleDataReader, VehicleDataReader>()
                .BuildServiceProvider();

            _logger = _serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            //LogApplicationState();

            //_logger.LogInformation("Starting application");

            //_applicationState = ApplicationStates.Loaded;
            //LogApplicationState();

            //List<Fruit> fruits = SearchingCollections.InitializeFruits();
            //Fruit found = SearchingCollections.GetFruitByIdWithFor(fruits, 101);
            //Fruit found1 = SearchingCollections.GetFruitByIdWithFind(fruits, 101);
            //Fruit found2 = SearchingCollections.GetFruitByIdWithLinq(fruits, 101);
            //OutputFoundFruit(found);
            //OutputFoundFruit(found1);
            //OutputFoundFruit(found2);

            //int value = 20;
            //_logger.LogInformation($"Factorial of {value} is {Recursion.CalculateFactorial(value)}");

            //ShapeDrawer.DrawRectangle(20, 20, true);

            //string value = "187";
            //Console.WriteLine(value[2]);
            //_logger.LogInformation($"Next number for {value} is {Recursion.GetNextNumber(value)}");

            int mainValue = 25;
            ByValueSimpleType(mainValue);
            _logger.LogInformation($"After ByVal value is {mainValue}");

            ByReferenceSimpleType(ref mainValue);
            _logger.LogInformation($"After ByRef value is {mainValue}");

            Vehicle vehicle = new Vehicle(_serviceProvider.GetService<IVehicleDataReader>(), "red");
            _logger.LogInformation($"Vehicle color is {vehicle.Color}");

            UpdateVehicle(vehicle);
            _logger.LogInformation($"Vehicle color is {vehicle.Color}");

            //_logger = loggerFactory.CreateLogger<Program>();

            //BasicProgramming.IfExample();

            //BasicProgramming.ForeachExample();

            //int sum = BasicProgramming.CalculateSumOfNumbersTill(100);
            //_logger.LogInformation($"Sum is {sum}");
            //sum = BasicProgramming.WhileExample(sum);
            //sum = BasicProgramming.DoWhileExample(sum);

            //List<Vehicle> vehicles = new List<Vehicle>();
            //try
            //{
            //    Car car1 = new Car(_serviceProvider.GetService<IVehicleDataReader>(), "red", "2022", 4);
            //    car1.MoveForward();
            //    car1.Break();
            //    string color = car1.Color;
            //    vehicles.Add(car1);

            //    Vehicle vehicle2 = new Vehicle(_serviceProvider.GetService<IVehicleDataReader>(), "blue", "2011");
            //    vehicle2.MoveForward();
            //    vehicles.Add(vehicle2);
            //}
            //catch (Exception ex)
            //{
            //   _logger.LogError(ex.Message);
            //}
            //finally
            //{
            //    _logger.LogDebug("Code of vehicle creation completed");
            //}

            //vehicles.Add(new Vehicle("blue"));
            //vehicles.Add(new Vehicle() { Color = "green" });
            //vehicles.Add(new Vehicle(color));

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    _logger.LogInformation(vehicle.ToString());
            //}

            Console.ReadKey();
        }

        private static void ByValueSimpleType(int value)
        {
            value = 15;
        }

        private static void ByReferenceSimpleType(ref int value)
        {
            value = 15;
        }

        private static void UpdateVehicle(Vehicle vehicle)
        {
            vehicle.Color = "purple";
        }

        private static void OutputFoundFruit(Fruit found)
        {
            if (found != null)
            {
                _logger.LogInformation(found.Name);
            }
            else
            {
                _logger.LogInformation("Fruit not found");
            }
        }

        private static void LogApplicationState()
        {
            switch (_applicationState)
            {
                case ApplicationStates.Initializing:
                case ApplicationStates.Loaded:
                    _logger.LogDebug($"Application is {_applicationState}");
                    break;
                case ApplicationStates.Exception:
                    _logger.LogDebug($"Application state: {_applicationState}");
                    break;
                case ApplicationStates.Exited:
                    _logger.LogDebug($"Application state: {_applicationState}");
                    break;
                default:
                    _logger.LogError($"Not implemented: {_applicationState}");
                    break;
            }
        }
    }

    enum ApplicationStates
    {
        Initializing = 12,
        Loaded = 55,
        Exception,
        Exited
    }
}
