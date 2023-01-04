#include <iostream>
#include <memory>
#include <string>
using std::string;
using std::to_string;
using std::cout;

#include "debug.cpp"

#if 1	//0

#if Production == 1
#define Log(Text) std::cout << Text << std::endl
#elif defined(Production)
#define Log(Text) Log(Text) std::cout << "Defined" << std::endl
#else
#define Log(Text)
#endif

#endif

#define MAIN(Value) int main() \
{\
	Value\
}




MAIN(
	Log("Some Text Production");
std::cout << "aaaa" << std::endl;
return EXIT_SUCCESS;
)
