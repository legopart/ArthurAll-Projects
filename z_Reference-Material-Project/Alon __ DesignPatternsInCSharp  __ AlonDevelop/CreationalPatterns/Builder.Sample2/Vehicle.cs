namespace Builder.Sample2;

/// <summary>
/// The 'Product' class
/// </summary>
class Vehicle
	{
		private VehicleType _vehicleType;
		private Dictionary<PartType, string> _parts = new Dictionary<PartType, string>();

		// Constructor
		public Vehicle(VehicleType vehicleType)
		{
			_vehicleType = vehicleType;
		}

		public string this[PartType key]
		{
			get { return _parts[key]; }
			set { _parts[key] = value; }
		}

		public void Show()
		{
			Console.WriteLine("\n---------------------------");
			Console.WriteLine("Vehicle Type: {0}", _vehicleType);
			Console.WriteLine(" Frame  : {0}",
				 this[PartType.Frame]);
			Console.WriteLine(" Engine : {0}",
				 this[PartType.Engine]);
			Console.WriteLine(" #Wheels: {0}",
				 this[PartType.Wheel]);
			Console.WriteLine(" #Doors : {0}",
				 this[PartType.Door]);
		}
	}


