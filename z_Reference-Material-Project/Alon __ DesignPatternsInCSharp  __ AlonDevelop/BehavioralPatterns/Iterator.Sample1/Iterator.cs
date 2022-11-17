namespace Iterator.Sample1;

// The 'ConcreteIterator' class
class Iterator : IAbstractIterator
{
	private Collection _collection;
	private int _current = 0;

	public Iterator(Collection collection)
	{
		this._collection = collection;
		Step = 1;
	}

	// Gets first item
	public Item? First()
	{
		_current = 0;
		return _collection[_current] as Item;
	}

	// Gets next item
	public Item? Next()
	{
		_current += Step;
		if (!IsDone)
			return _collection[_current] as Item;
		else
			return null;
	}

	// Gets or sets stepsize
	public int Step { get; set; }

	// Gets current iterator item
	public Item? CurrentItem
	{
		get { return _collection[_current] as Item; }
	}

	// Gets whether iteration is complete
	public bool IsDone
	{
		get { return _current >= _collection.Count; }
	}
}

