#include <iostream>
#include <functional>


using std::cout;
using std::function;

int sum(int a, int b) { return a + b; }



int main() 
{
	//function pointer
	int (*func)(int a, int b);
	func = &sum;
	cout << func(1, 2);

	//std::function
	function<int(int, int)> func2;
	func2 = sum;
	cout << func2(1, 2);


	return EXIT_SUCCESS;
}