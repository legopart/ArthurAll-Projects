namespace FactoryMethod.Sample1;

/// <summary>
/// The 'Product' abstract class
/// </summary>
abstract class Page
{
	// Override. Display class name
	public override string ToString()
	{
		return this.GetType().Name;
	}
}

