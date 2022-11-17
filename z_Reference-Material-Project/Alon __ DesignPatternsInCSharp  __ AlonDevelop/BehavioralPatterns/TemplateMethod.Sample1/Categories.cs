using System.Data;
using System;

namespace TemplateMethod.Sample1
{

	// A 'ConcreteClass' class
	class Categories : DataAccessObject
	{
		public override void Select()
		{
			string sql = "select CategoryName from Categories";
			var dataAdapter = new System.Data.OleDb.OleDbDataAdapter(
				 sql, connectionString);

			dataSet = new DataSet();
			dataAdapter.Fill(dataSet, "Categories");
		}

		public override void Process()
		{
			Console.WriteLine("Categories ---- ");

			var dataTable = dataSet.Tables["Categories"];
			foreach (DataRow row in dataTable.Rows)
			{
				Console.WriteLine(row["CategoryName"]);
			}
			Console.WriteLine();
		}
	}
}

