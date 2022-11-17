namespace Adapter.Sample1;

/// <summary>
/// The 'Target' class
/// </summary>
class Compound
{
	public Chemical Chemical { get; protected set; }
	public float BoilingPoint { get; protected set; }
	public float MeltingPoint { get; protected set; }
	public double MolecularWeight { get; protected set; }
	public string? MolecularFormula { get; protected set; }

	public virtual void Display()
	{
		Console.WriteLine("\nCompound: Unknown ------ ");
	}
}
