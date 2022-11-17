using System;
using System.Collections.Generic;

namespace Builder.Sample2;

/// <summary>
/// MainApp startup class for .NET optimized 
/// Builder Design Pattern.
/// </summary>
public class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Create shop
			var shop = new Shop();

			// Construct and display vehicles
			shop.Construct(new ScooterBuilder());
			shop.ShowVehicle();

			shop.Construct(new CarBuilder());
			shop.ShowVehicle();

			shop.Construct(new MotorCycleBuilder());
			shop.ShowVehicle();
		}

		internal static void ConstructCar(Shop shop)
		{
			shop.Construct(new CarBuilder());
			shop.ShowVehicle();
		}
	}


