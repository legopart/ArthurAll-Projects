namespace Strategy.Sample1;

// A 'ConcreteStrategy' class
class ShellSort : ISortStrategy
{
	public void Sort(IList<Student> list)
	{
		// ShellSort();  not-implemented
		Console.WriteLine("ShellSorted list ");
	}
}

