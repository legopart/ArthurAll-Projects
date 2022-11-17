namespace AbstractFactory.Sample2;

/// <summary>
/// The 'ConcreteFactory1' class.
/// </summary>
class Africa : IContinentFactory
	{
		public IHerbivore CreateHerbivore()
		{
			return new Wildebeest();
		}

		public ICarnivore CreateCarnivore()
		{
			return new Lion();
		}
	}

