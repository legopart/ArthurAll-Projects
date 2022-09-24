#include "ArthurClass.h"

ArthurClass::ArthurClass(string val)
    : regVar(0), constVar(0)//, value(val)      //member initializer, important for constant variables!
{  //constructor
    setValue(val);
    cout << "constructor called2" << endl;
}

ArthurClass::ArthurClass(int a, int b, string val)
    : regVar(a), constVar(b)
{
    setValue(val);
}

ArthurClass::~ArthurClass() {  //destructor
    cout << "destructor called" << endl;
}

ArthurClass ArthurClass::operator+ (ArthurClass anotherArthurObject) {
    ArthurClass newArthurObject(anotherArthurObject.getValue());
    newArthurObject.regVar = regVar = anotherArthurObject.regVar + 100;
    return (newArthurObject);
}

void ArthurClass::polimorficlyFunction() {
    cout << "abfbdfgbdfbd" << endl;
}

int ArthurClass::operator+ (int anotherVal) /*const*/ {
    //can 
    // regVar += anotherVal + 100;
    // return this->regVar;
    this->regVar += anotherVal + 100;   //this pointer
    return this->regVar;
}

void ArthurClass::cool() {
    cout << "wow " << value << endl;    //wow exellent !!!!
}

string ArthurClass::getConst() const {
    return "CONST FUNCTION VALUE";
}

string ArthurClass::getValue() { return value; }

void ArthurClass::setValue(string val) { value = val; }