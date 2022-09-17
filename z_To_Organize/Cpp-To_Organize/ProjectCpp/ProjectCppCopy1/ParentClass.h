#pragma once
#include <iostream>
#include <string> 
using namespace std;





struct ParentClass
{
	//constructure will inhiret only if inhirite class do not having a constructure
	//but still the parent constructure will run first
	//the deconstructor will run last

private:

protected:

public:
	virtual ~ParentClass();
	template <class T>
	T tFoo();
	string parantFoo();
	virtual void polimorficlyFunction() = 0;	//specific class will active it differently
	//	=0 pure virtual function no implementation for parrent, must implement in child!
	class Spunky;




};

