﻿namespace Builder.Sample1;

/// <summary>
/// The 'Director' class
/// </summary>
class Shop
	{
		// Builder uses a complex series of steps
		public void Construct(VehicleBuilder vehicleBuilder)
		{
			vehicleBuilder.BuildFrame();
			vehicleBuilder.BuildEngine();
			vehicleBuilder.BuildWheels();
			vehicleBuilder.BuildDoors();
		}
	}


