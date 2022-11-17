namespace AbstractFactory.Sample1;

class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Create and run the African animal world
		ContinentFactory africa = new AfricaFactory();
		AnimalWorld world = new AnimalWorld(africa);
		world.RunFoodChain();

		// Create and run the American animal world
		ContinentFactory america = new AmericaFactory();
		world = new AnimalWorld(america);
		world.RunFoodChain();
	}
}

