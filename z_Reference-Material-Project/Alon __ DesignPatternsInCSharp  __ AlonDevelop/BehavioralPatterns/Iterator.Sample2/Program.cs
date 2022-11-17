namespace Iterator.Sample2;
class Program
{
	static void Main()
	{
		// Create and item collection
		var collection = new ItemCollection<Item> {
				new Item{ Name = "Item 0"},
				new Item{ Name = "Item 1"},
				new Item{ Name = "Item 2"},
				new Item{ Name = "Item 3"},
				new Item{ Name = "Item 4"},
				new Item{ Name = "Item 5"},
				new Item{ Name = "Item 6"},
				new Item{ Name = "Item 7"},
				new Item{ Name = "Item 8"}
		 };

		Console.WriteLine("Iterate front to back");
		foreach (var item in collection)
		{
			Console.WriteLine(item.Name);
		}

		Console.WriteLine("\nIterate back to front");
		foreach (var item in collection.BackToFront)
		{
			Console.WriteLine(item.Name);
		}
		Console.WriteLine();

		// Iterate given range and step over even ones
		Console.WriteLine("\nIterate range (1-7) in steps of 2");
		foreach (var item in collection.FromToStep(1, 7, 2))
		{
			Console.WriteLine(item.Name);
		}
		Console.WriteLine();

	}
}

