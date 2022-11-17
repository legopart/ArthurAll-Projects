using System;
using System.Collections.Generic;

namespace Decorator.Sample1;

class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Create book
		Book book = new Book("Don Box", "Essential COM", 10);
		book.Display();

		// Create video
		Video video = new Video("Spielberg", "Jaws", 23, 92);
		video.Display();

		// Make video borrowable, then borrow and display
		Console.WriteLine("\nMaking video borrowable:");

		Borrowable borrowvideo = new Borrowable(video);
		borrowvideo.BorrowItem("Customer #1");
		borrowvideo.BorrowItem("Customer #2");

		borrowvideo.Display();
	}
}

