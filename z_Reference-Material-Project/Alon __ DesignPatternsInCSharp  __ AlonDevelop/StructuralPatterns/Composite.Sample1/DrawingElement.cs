namespace Composite.Sample1;

// The 'Component' class
abstract class DrawingElement
{
	public string Name { get; private set; }

	// Constructor
	public DrawingElement(string name)
	{
		Name = name;
	}

	public abstract void Add(DrawingElement d);
	public abstract void Remove(DrawingElement d);
	public abstract void Display(int indent);
}

