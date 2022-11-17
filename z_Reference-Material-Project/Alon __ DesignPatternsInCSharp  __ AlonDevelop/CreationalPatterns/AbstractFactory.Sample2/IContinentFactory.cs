namespace AbstractFactory.Sample2;

/// <summary>
/// The 'AbstractFactory' interface. 
/// </summary>
interface IContinentFactory
	{
		IHerbivore CreateHerbivore();
		ICarnivore CreateCarnivore();
	}

