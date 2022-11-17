namespace Decorator.Sample1;

// The 'Decorator' abstract class
abstract class Decorator : LibraryItem
{
	protected LibraryItem libraryItem;

	// Constructor
	public Decorator(LibraryItem libraryItem)
	{
		this.libraryItem = libraryItem;
	}

	public override void Display()
	{
		libraryItem.Display();
	}
}

