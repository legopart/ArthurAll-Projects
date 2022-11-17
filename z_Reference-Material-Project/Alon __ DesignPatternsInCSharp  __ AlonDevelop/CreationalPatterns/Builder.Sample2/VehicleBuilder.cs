namespace Builder.Sample2;

/// <summary>
/// The 'Builder' abstract class
/// </summary>
abstract class VehicleBuilder
	{
		public Vehicle Vehicle { get; private set; }

		// Constructor
		protected VehicleBuilder(VehicleType vehicleType)
		{
			Vehicle = new Vehicle(vehicleType);
		}

		public abstract void BuildFrame();
		public abstract void BuildEngine();
		public abstract void BuildWheels();
		public abstract void BuildDoors();
	}


