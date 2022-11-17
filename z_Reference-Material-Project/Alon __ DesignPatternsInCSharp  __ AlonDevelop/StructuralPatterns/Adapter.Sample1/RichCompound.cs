namespace Adapter.Sample1;

// The 'Adapter' class
class RichCompound : Compound
{
	private ChemicalDatabank _bank;

	// Constructor
	public RichCompound(Chemical chemical)
	{
		Chemical = chemical;

		// The Adaptee
		_bank = new ChemicalDatabank();
	}

	public override void Display()
	{
		// Adaptee request methods
		BoilingPoint = _bank.GetCriticalPoint(Chemical, State.Boiling);
		MeltingPoint = _bank.GetCriticalPoint(Chemical, State.Melting);
		MolecularWeight = _bank.GetMolecularWeight(Chemical);
		MolecularFormula = _bank.GetMolecularStructure(Chemical);

		Console.WriteLine("\nCompound: {0} ------ ", Chemical);
		Console.WriteLine(" Formula: {0}", MolecularFormula);
		Console.WriteLine(" Weight : {0}", MolecularWeight);
		Console.WriteLine(" Melting Pt: {0}", MeltingPoint);
		Console.WriteLine(" Boiling Pt: {0}", BoilingPoint);
	}
}
