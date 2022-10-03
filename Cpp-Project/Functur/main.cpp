#include <iostream>
#include <functional>


using std::cout;
using std::endl;
using std::function;

int sum(int a, int b) { return a + b; }




int someFun11( int a, int b, int (*func11)(int x, int y) ) 
{
	return func11(a, b);
}


typedef int (*func1x)(int a, int b);
int someFun12(int a, int b, func1x  func12)
{
	return func12(a, b);
}


int someFun21(int a, int b, function<int(int, int)> func21)
{
	return func21(a, b);
}

using func2x = function<int(int, int)>;
int someFun22(int a, int b, func2x func22)
{
	return func22(a, b);
}




int main() 
{
	//function pointer
	int (*func)(int a, int b);
	func = &sum;
	cout << func(1, 2) << endl;
	cout << someFun11(1, 2, &sum) << endl;
	cout << someFun12(1, 2, &sum) << endl;


	//std::function
	function<int(int, int)> func2;
	func2 = sum;
	cout << func2(1, 2) << endl;
	cout << someFun21(1, 2, sum) << endl;
	cout << someFun22(1, 2, sum) << endl;

	return EXIT_SUCCESS;
}