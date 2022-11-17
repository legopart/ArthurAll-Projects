namespace Visitor.Sample1;

// The 'Element' abstract class
abstract class Element
{
	public abstract void Accept(IVisitor visitor);
}

