// Template.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>


template<typename T>
void Print(T value)
{
    std::cout << value << std::endl;
    //std::cout << value << " a = " << a << std::endl;
}



template<unsigned int N>
struct Power
{
    static constexpr int64_t value(int i) { return i * Power<N - 1>::value(i); }    
};



template<>
struct Power<1>
{
    static constexpr int64_t value(int i) { return i; };
};



template<unsigned int N>
unsigned int Pow(int i)  {  return i * Pow<N - 1>(i); }

template<>
unsigned int Pow<1>(int i) { return i; }




//To fix
//template<unsigned int A, unsigned int B>
//unsigned int Pow2() { return B * Pow2<A-1, B>(); }
//
//template<unsigned int B>
//unsigned int Pow2<1, B>() { return B; }


int main()
{
    Print("hello");
    
    Print(5);

    std::cout << "class/struct, 5^4 = " << Power<4>::value(5) << std::endl;

    std::cout << "function, 5^4 = " << Pow<4>(5) << std::endl;

   /// std::cout << "function2, 5^4 = " << Pow2<5, 4>() << std::endl;
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
