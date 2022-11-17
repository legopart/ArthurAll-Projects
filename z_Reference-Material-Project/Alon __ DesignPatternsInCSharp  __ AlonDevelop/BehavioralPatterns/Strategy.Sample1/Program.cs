namespace Strategy.Sample1;
class Program
{
	static void Main()
	{
		// Two contexts following different strategies
		var studentRecords = new SortedList() {
				new Student{ Name = "Homer", Id = "655-00-2944" },
				new Student{ Name = "Marge", Id = "760-94-9844" },
				new Student{ Name = "Bart", Id = "154-33-2009" },
				new Student{ Name = "Lisa", Id = "487-43-1665" },
				new Student{ Name = "Maggie", Id = "133-98-8399" },
		 };

		studentRecords.SortStrategy = new QuickSort();
		studentRecords.SortStudents();

		studentRecords.SortStrategy = new ShellSort();
		studentRecords.SortStudents();

		studentRecords.SortStrategy = new MergeSort();
		studentRecords.SortStudents();
	}
}

// The 'Strategy' interface
interface ISortStrategy
{
	void Sort(IList<Student> list);
}

