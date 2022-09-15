// ArrayList.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
 
#include <iostream>
#include "Array.cpp"

int main()
{
	// ליצור גירסה עם T שדומה לסרטון  https://www.youtube.com/watch?v=qEJOPRkMa8A
	Array* array = new Array(5);
	array->add(5);
	array->add(2);
	array->add(1);
	array->add(3);
	array->add(7);
	array->add(3);
	array->add(7);

	std::cout << (array->contains(5) ? "true" : "false") << "\n";
	array->print();
	array->remove(2);
	array->print();
std::cout << "Hello World!\n";

}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
