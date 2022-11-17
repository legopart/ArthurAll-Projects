namespace Strategy.Sample1;

// A 'ConcreteStrategy' class
class MergeSort : ISortStrategy
{
	public void Sort(IList<Student> list)
	{
		// MergeSort(); not-implemented
		Console.WriteLine("MergeSorted list ");
	}
}

