// ConsoleAdv.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string> //#include <iterator>
#include <vector>
#include <algorithm>
using namespace std;


class Test2 {
private:
    int id;
    string name;
public:
    Test2() : id(0), name("") {}   //default constructure
    Test2(int id, string name) : id(id), name(name) {}
    // ~Test() { cout << "Obj-dstryd" << endl; }
    void print() const { cout << this->id << ": " << this->name << endl; }
    const Test2 operator=(const Test2& other) { //return other; //regular
        this->id = other.id;  this->name = other.name; cout << "equal operator" << endl; return *this;
    } // return *this = other;
    Test2(const Test2& other) {     //copy constructur //Roll of 3!!! (if you use 1 of constructur/destructur/copy-constructur you have to set them all)
        this->id = other.id; this->name = other.name; cout << "copy constructur" << endl;
    } ////*this = other;  //not works
    friend ostream& operator<<(ostream& out, const Test2& test) { out << test.id << ": " << test.name;  return out; } //ostream, type of cout
};


class Complex {
private:
    double real;
    double imaginary;
public:
    Complex() : real(0), imaginary(0) { };
    Complex(double real, double imaginaty) : real(real), imaginary(imaginaty) { };
    Complex(const Complex& other) { this->real = other.real; this->imaginary = other.imaginary; };
    const Complex& operator=(const Complex& other) { this->real = other.real; this->imaginary = other.imaginary; return *this; }
    double getReal() const { return real; }
    double getImaginary() const { return imaginary; }
    friend ostream& operator<<(ostream& out, const Complex& complex) { out << "" << complex.getReal() << ((complex.getImaginary() >= 0) ? "+" : "") << complex.getImaginary() << "i"; return out; } //ostream, type of cout
    friend Complex operator+(const Complex& c1, const Complex& c2) { return Complex(c1.getReal() + c2.getReal(), c1.getImaginary() + c2.getImaginary()); }
    friend Complex operator+(const Complex& c1, const double d) { return Complex(c1.getReal() + d, c1.getImaginary()); }
    friend Complex operator+(const double d, const Complex& c1) { return operator+(c1, d); }
    bool operator==(const Complex& other) const { return this->real == other.real && this->imaginary == other.imaginary; };
    bool operator!=(const Complex& other) const { return !(*this == (other)); };   //return !(operator==(other));
    Complex operator*() { return Complex(real, -imaginary); } //star operator
    // overload ()
    // overload []
    // overload {}
};    // search for more operators that can overload


template<class T, class K>
class Test {
private:
    T obj;
public:
    Test(T obj) { this->obj = obj; }
    void print() { cout << obj << endl; }
};



template <typename T>
void print(T n) { cout << n << endl; }

void print(int i) { cout << i << flush; }

template <typename T>
void test1() { cout << T() << endl; }

void test(int value) { cout << "Hello From Function" << value << endl; }

bool match(string test) { return test.size() == 3; }
int countString(vector<string>& texts, bool (*match)(string test)) { //(parametar)
    int tally = 0;
    for (int i = 0; i < texts.size(); i += 1) { if (match(texts[i])) tally += 1; }
    return tally;
}

class Parant {
private:
    int one;
public:
    Parant() : one(0) {}
    Parant(const Parant& other) : one(0) {
        this->one = other.one;
        cout << "copy par cnstr" << endl;
    }; // copy constructur
    virtual void print() { cout << "parent" << endl; };
    virtual ~Parant() { };// copy destructur
};

class Child : public Parant {
private:
    int two;
public:
    Child() : two(0) {}
    void print() { cout << "child" << endl; };
};

int main() {
    cout << "Function pointer:" << endl;

    Child ch1;
    Parant& pa1 = ch1;
    pa1.print(); //"child" because of virtual

    Parant pa2 = Child();
    pa2.print(); //"parant"




    vector <string> texts;
    texts.push_back("one");
    texts.push_back("two");
    texts.push_back("three");
    texts.push_back("one");
    texts.push_back("two");
    texts.push_back("three");

    cout << match("one") << endl;
    // cout << count_if(texts.begin(), texts.end(), match) << endl;
    cout << countString(texts, match) << endl;


    //test();
   // void (* pTest)();
   // pTest = test; //pointer not require, function is a reference pTest = &test;
    void (*pTest)(int) = test;
    (*pTest)(5);

    cout << endl;

    cout << "Templates:" << endl;
    test1<int>();
    cout << endl;
    Test<string, int> test1("hello");
    test1.print();
    print(123445);
    print<>(563463);    //template set
    print("some string");

    cout << endl;

    cout << "Complex:" << endl;
    Complex c1(2, 3);
    Complex c3(5, 5);
    Complex c2 = c1;
    c1 = c2;
    cout << c1 << endl;
    cout << 100 + c1 + c3 << endl;
    cout << *c3 << endl;
    cout << endl;

    cout << "Operators:" << endl;
    //test1 = test2 = test3;
    //test1.oprator = test2;
    cout << "Deep Copy:" << endl;
    Test2 test21(10, "Mike");
    Test2 test22(20, "Bob");
    test22 = test21;
    Test2 test23 = test21;
    cout << "Operator Print: " << test21 << endl;
    cout << endl;
    //Test test4=test1; //copy initialization!!! using copy constructure
    return 0;
}

