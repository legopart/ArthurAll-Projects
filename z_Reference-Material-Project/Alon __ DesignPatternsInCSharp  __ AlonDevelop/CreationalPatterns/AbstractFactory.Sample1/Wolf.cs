namespace AbstractFactory.Sample1;

/// <summary>
/// The 'ProductB2' class
/// </summary>
class Wolf : Carnivore
{
	public override void Eat(Herbivore h)
	{
		// Eat Bison
		Console.WriteLine(this.GetType().Name +
			 " eats " + h.GetType().Name);
	}
}

