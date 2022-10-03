#include <iostream>
#include <functional>


using std::cout;
using std::endl;
using std::function;

int sum(int a, int b);

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





int sum(int a, int b) { return a + b; }


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

	using FuncSignature  = int(int, int);
	function<FuncSignature> func2_1;

	//lambda
	// [=] () mutable throw -> int { return 0; }
	// [a, &b] [this] [&] [=]
	// []{} no parametars
	const auto func3 = [](int a, int b) -> int { return a + b; } ;
	cout << someFun22(1, 2, [](int a, int b) -> int { return a + b; }) << endl;
	cout << someFun22(1, 2, func3) << endl;

	int val = 4;
	[val = 100 /*move*/] { cout << "lambda " << val << endl; }();

	//bind
	using namespace std::placeholders;	//_1 _2
	auto func4 = std::bind(sum, _1, _2); 
	//Class classObj;
	// &sum for class method (non static) std::bind( &Class::sum, classObj, _1, _2 )
	// for static  std::bind( Class::sum, _1, _2 )
	cout << func4(1, 2) << endl;

	return EXIT_SUCCESS;
}