using System;
using System.Collections.Generic;

namespace Visitor.Sample1;

class Program
{
	static void Main()
	{
		// Setup employee collection
		Employees e = new Employees();
		e.Attach(new Clerk());
		e.Attach(new Director());
		e.Attach(new President());

		// Employees are 'visited'
		e.Accept(new IncomeVisitor());
		e.Accept(new VacationVisitor());
	}
}

