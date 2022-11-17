namespace AbstractFactory.Sample1;

/// <summary>
/// The 'ConcreteFactory2' class
/// </summary>
class AmericaFactory : ContinentFactory
{
	public override Herbivore CreateHerbivore()
	{
		return new Bison();
	}
	public override Carnivore CreateCarnivore()
	{
		return new Wolf();
	}
}

