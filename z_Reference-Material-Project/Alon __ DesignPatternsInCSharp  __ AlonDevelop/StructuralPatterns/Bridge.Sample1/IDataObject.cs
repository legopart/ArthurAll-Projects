namespace Bridge.Sample1;

// The 'Implementor' interface
interface IDataObject<T>
{
	void NextRecord();
	void PriorRecord();
	void AddRecord(T t);
	void DeleteRecord(T t);
	T GetCurrentRecord();
	void ShowRecord();
	void ShowAllRecords();
}

