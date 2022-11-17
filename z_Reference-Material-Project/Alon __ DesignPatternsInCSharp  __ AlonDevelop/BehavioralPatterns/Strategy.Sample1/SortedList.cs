namespace Strategy.Sample1;

// The 'Context' class
class SortedList : List<Student>
{
	// Sets sort strategy
	public ISortStrategy? SortStrategy { get; set; }

	// Perform sort
	public void SortStudents()
	{
		SortStrategy?.Sort(this);

		// Display sort results
		foreach (var student in this)
		{
			Console.WriteLine(" " + student.Name);
		}
		Console.WriteLine();
	}
}

