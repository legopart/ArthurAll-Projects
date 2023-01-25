#include <iostream>
#include <memory>
#include <string>
using std::string;
using std::to_string;
using std::cout;

#include "config.cpp"


#if 1	//0

	#define MAIN(Value) int main() \
	{\
		Value\
	}

	MAIN(
		Log("Some Text Production");
	std::cout << "aaaa" << std::endl;
	return EXIT_SUCCESS;
	)

#endif