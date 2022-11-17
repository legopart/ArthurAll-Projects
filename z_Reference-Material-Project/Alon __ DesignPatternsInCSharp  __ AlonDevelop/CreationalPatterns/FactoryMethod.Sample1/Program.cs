namespace FactoryMethod.Sample1;

class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Document constructors call Factory Method
			var documents = new List<Document> { new Resume(), new Report() };

			// Display document pages
			foreach (var document in documents)
			{
				Console.WriteLine(document + "--");
				foreach (var page in document.Pages)
				{
					Console.WriteLine(" " + page);
				}
				Console.WriteLine();
			}
		}
	}

