using System;
using System.Data.OleDb;

namespace TemplateMethod.Sample1
{
	class Program
	{
		static void Main()
		{
			DataAccessObject daoCategories = new Categories();
			daoCategories.Run();

			DataAccessObject daoProducts = new Products();
			daoProducts.Run();
		}
	}
}

