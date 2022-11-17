namespace AbstractFactory.Sample2;

/// <summary>
/// The 'Client' class
/// </summary>
class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
	{
		private IHerbivore _herbivore;
		private ICarnivore _carnivore;
		private T _factory;

		/// <summary>
		/// Contructor of Animalworld
		/// </summary>
		public AnimalWorld()
		{
			// Create new continent factory
			_factory = new T();

			// Factory creates carnivores and herbivores
			_carnivore = _factory.CreateCarnivore();
			_herbivore = _factory.CreateHerbivore();
		}

		/// <summary>
		/// Runs the foodchain, that is, carnivores are eating herbivores.
		/// </summary>
		public void RunFoodChain()
		{
			_carnivore.Eat(_herbivore);
		}
	}

