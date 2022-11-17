namespace Bridge.Sample1;

// The 'Abstraction' class
class CustomersBase
{
	// Gets or sets data object
	public IDataObject<string> DataObject { get; set; }

	public virtual void Next()
	{
		DataObject.NextRecord();
	}

	public virtual void Prior()
	{
		DataObject.PriorRecord();
	}

	public virtual void Add(string name)
	{
		DataObject.AddRecord(name);
	}

	public virtual void Delete(string name)
	{
		DataObject.DeleteRecord(name);
	}

	public virtual void Show()
	{
		DataObject.ShowRecord();
	}

	public virtual void ShowAll()
	{

		DataObject.ShowAllRecords();
	}
}

