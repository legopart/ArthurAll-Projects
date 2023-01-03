// Mutable.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>



//mutable

class ClsA
{
public:
    mutable int x = 5;
    int y = 2;
    int Foo() const
    {
        //++y;
        ++x;
        return x;
    }
};


void PrintClsA(const ClsA& clsA)
{
    std::cout << "print() foo = " << clsA.Foo() << std::endl;
}


int main()
{
    ClsA clsA;
    clsA.Foo();

    std::cout << "class x = " << clsA.x << std::endl;


    int x = 5;
    auto foo = [=]() mutable    //do awailable to change
    {
        ++x;

        std::cout << "lambda x = " << x << std::endl;
    };

    foo();

    std::cout << "external x = " << x << std::endl;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
