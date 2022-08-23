#pragma once
#include <iostream>
#include <string> 
#include "ParentClass.h"

using namespace std;

class ArthurClass : public ParentClass { // == struct

private:
    void setValue(string val);
    string value;
    int regVar{ 4 }; //begin value
    const int constVar;     //cant change it
protected:


public:
    //ArthurClass() = default;
    explicit ArthurClass(string val);
    ArthurClass(int a, int b, string val); // ArthurClass(int, int, string);
    ~ArthurClass();
    string getValue();
    void cool();
    string getConst() const;
    ArthurClass operator+ (ArthurClass);
    int operator+ (int);

    void polimorficlyFunction();

};

