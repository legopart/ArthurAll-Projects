#include <iostream>
#include <memory>
#include <string>
using std::string, std::to_string, std::cout, std::unique_ptr, std::make_unique, std::move, std::shared_ptr, std::make_shared, std::weak_ptr;


class MyClass {
private:
	int a;
public:
	explicit MyClass(int a) : a{a} { std::cout << "created:" << a << "\n"; }
	~MyClass() { std::cout << "deleted;" << a << "\n"; }
};

int main(){
	std::cout << "unique pointer \n";
	std::unique_ptr<int> unPtr1 = std::make_unique<int>(25);
	std::unique_ptr<int> unPtr2 = std::move(unPtr1);
	std::cout << *unPtr2 << "\n";
	//unPtr1 is nullptr
	{
		std::unique_ptr<MyClass> unPtr3 = std::make_unique<MyClass>(1);
	}
	
	{
		std::shared_ptr<MyClass> shPtr1 = std::make_shared<MyClass>(2);
		{
			std::shared_ptr<MyClass> shPtr2 = shPtr1;
			std::cout << "Shared Count: " << shPtr1.use_count() << "\n";
		}
		std::cout << "Shared Count: " << shPtr1.use_count() << "\n";
	}

	std::weak_ptr<int> wePtr1;
	{
		std::shared_ptr<int> shPtr4 = std::make_shared<int>(245);
		wePtr1 = shPtr4;	//same memory location
	}
	// only the address to the object, no more value of allocated element


	std::cout << "\n\n";
	std::cin.get();
	return 0;
}
