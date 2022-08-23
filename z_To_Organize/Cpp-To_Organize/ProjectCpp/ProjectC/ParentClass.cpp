#include "ParentClass.h"


ParentClass::~ParentClass()
{
}

string ParentClass::parantFoo() {
	return "hellow from parant class";
};

template <class T>
T ParentClass::tFoo() {
}

//void ParentClass::polimorficlyFunction() {};




template <class T>	//first generic
class Spunky {
public:
	Spunky(T x) {
		cout << x << "is not char";
	}
};

template <>	//if I working with chart
class Spunky<char> {
public:
	Spunky(char x) {
		cout << x << "is a char";
	}
};


/*

int main(){

	Spunky<int> obj1(7);
	Spunky<double> obj1(3.57);
	Spunky<char> obj1('a');

}


*/