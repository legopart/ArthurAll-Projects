namespace Decorator.Sample1;

// The 'Component' abstract class
abstract class LibraryItem
{
	private int _numCopies;

	public int NumCopies { get; set; }

	public abstract void Display();
}

