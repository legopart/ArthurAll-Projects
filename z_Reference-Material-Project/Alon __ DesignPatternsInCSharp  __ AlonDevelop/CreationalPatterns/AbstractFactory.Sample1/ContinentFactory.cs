namespace AbstractFactory.Sample1;

/// <summary>
/// The 'AbstractFactory' abstract class
/// </summary>
abstract class ContinentFactory
{
	public abstract Herbivore CreateHerbivore();
	public abstract Carnivore CreateCarnivore();
}

