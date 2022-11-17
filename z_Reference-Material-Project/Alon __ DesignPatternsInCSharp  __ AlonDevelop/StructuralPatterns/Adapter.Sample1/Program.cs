using System;

namespace Adapter.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Non-adapted chemical compound 
		var unknown = new Compound();
		unknown.Display();

		// Adapted chemical compounds
		var water = new RichCompound(Chemical.Water);
		water.Display();

		var benzene = new RichCompound(Chemical.Benzene);
		benzene.Display();

		var ethanol = new RichCompound(Chemical.Ethanol);
		ethanol.Display();
	}
}
