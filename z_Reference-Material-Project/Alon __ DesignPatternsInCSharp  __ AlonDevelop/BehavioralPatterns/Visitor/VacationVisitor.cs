﻿namespace Visitor.Sample1;

// A 'ConcreteVisitor' class
class VacationVisitor : IVisitor
{
	public void Visit(Element element)
	{
		Employee employee = element as Employee;

		// Provide 3 extra vacation days
		Console.WriteLine("{0} {1}'s new vacation days: {2}",
			 employee.GetType().Name, employee.Name,
			 employee.VacationDays);
	}
}

