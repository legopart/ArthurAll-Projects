using System.Data;

namespace TemplateMethod.Sample1
{

	// The 'AbstractClass' abstract class
	abstract class DataAccessObject
	{
		protected string connectionString;
		protected DataSet dataSet;

		public virtual void Connect()
		{
			// Make sure mdb is available to app
			connectionString =
				 "provider=Microsoft.JET.OLEDB.4.0; " +
				 "data source=..\\..\\db1.mdb";
		}

		public abstract void Select();
		public abstract void Process();

		virtual public void Disconnect()
		{
			connectionString = "";
		}

		// The 'Template Method' 
		public void Run()
		{
			Connect();
			Select();
			Process();
			Disconnect();
		}
	}
}
