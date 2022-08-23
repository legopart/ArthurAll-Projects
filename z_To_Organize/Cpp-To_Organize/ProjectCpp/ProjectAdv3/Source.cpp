#include <iostream>
#include <string> //#include <iterator>

using namespace std;

void test(void (*pFunc)()) { pFunc(); }

class Test {
private:
    int one{ 1 };
    int two{ 2 };
public:
    void run() {
        int three{ 3 };
        int four{ 4 };
        auto pLambda = [&, this]() {
            one = 111;
            cout << one << two << three << four << endl;
        };
        pLambda();
    }
};




int main() {
    auto func1 = []() { cout << "Lambda expression:" << endl; };
    test(func1);

    auto func2 = [](string name) { cout << name << endl; };
    func2("Arthur");

    auto pDivide = [](double a, double b) -> double { if (b == 0) { return 0; };return a / b; };
    cout << pDivide(10.0, 2.0) << endl;
    cout << pDivide(10.0, 0) << endl;

    int one{ 1 };
    int two{ 2 };
    int three{ 3 };

    [one, two, three]() { cout << one << ": " << two << endl; }();
    [=]() { cout << one << ": " << two << endl; }();    //all local variables by value
    [=, &three]() {three=7;cout << one << ": " << two << ": " << three << endl; }();
    cout << three << endl;
    [&]() {three = 1; one =5;cout << one << ": " << two << ": " << three << endl; }();  //all local variables by reference
    auto aa=[&, two, three]() {one = 1;cout << one << ": " << two << ": " << three << endl; };    // two, three by value
    aa();

    // in class you can use [this]() {  ... 
    return 0;
}