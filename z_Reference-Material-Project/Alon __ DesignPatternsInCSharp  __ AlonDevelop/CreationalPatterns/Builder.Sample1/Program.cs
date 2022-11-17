using System;
using System.Collections.Generic;

namespace Builder.Sample1;
public class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			VehicleBuilder builder;

			// Create shop with vehicle builders
			Shop shop = new Shop();

			// Construct and display vehicles
			builder = new ScooterBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();

			builder = new CarBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();

			builder = new MotorCycleBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();
		}
	}


