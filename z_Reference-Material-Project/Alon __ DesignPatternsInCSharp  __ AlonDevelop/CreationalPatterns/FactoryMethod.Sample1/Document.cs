namespace FactoryMethod.Sample1;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
abstract class Document
{
	// Constructor invokes Factory Method
	public Document()
	{
		this.CreatePages();
	}

	// Gets list of document pages
	public List<Page> Pages { get; protected set; } = new List<Page>();

	// Factory Method
	public abstract void CreatePages();

	// Override
	public override string ToString()
	{
		return this.GetType().Name;
	}
}

