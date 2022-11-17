namespace Builder.Sample2;

/// <summary>
/// The 'Director' class
/// </summary>
class Shop
	{
		private VehicleBuilder? _vehicleBuilder;

		// Builder uses a complex series of steps
		public void Construct(VehicleBuilder vehicleBuilder)
		{
			_vehicleBuilder = vehicleBuilder;

			_vehicleBuilder.BuildFrame();
			_vehicleBuilder.BuildEngine();
			_vehicleBuilder.BuildWheels();
			_vehicleBuilder.BuildDoors();
		}

		public void ShowVehicle()
		{
			_vehicleBuilder!.Vehicle.Show();
		}
	}


