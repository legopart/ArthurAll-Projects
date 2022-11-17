using System.Collections;

namespace Iterator.Sample2;

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>
/// <typeparam name="T">Collection item type</typeparam>
class ItemCollection<T> : IEnumerable<T>
{
	private List<T> _items = new List<T>();

	public void Add(T t)
	{
		_items.Add(t);
	}

	// The 'ConcreteIterator'
	public IEnumerator<T> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return _items[i];
		}
	}

	public IEnumerable<T> FrontToBack
	{
		get { return this; }
	}

	public IEnumerable<T> BackToFront
	{
		get
		{
			for (int i = Count - 1; i >= 0; i--)
			{
				yield return _items[i];
			}
		}
	}

	public IEnumerable<T> FromToStep(int from, int to, int step)
	{
		for (int i = from; i <= to; i = i + step)
		{
			yield return _items[i];
		}
	}

	// Gets number of items
	public int Count
	{
		get { return _items.Count; }
	}

	// System.Collections.IEnumerable member implementation
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

