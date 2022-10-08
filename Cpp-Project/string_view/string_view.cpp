// DataStructures_Algorithms_Cpp.cpp : Defines the entry point for the application.
//


#include <iostream>
#include <string>
#include <string_view>
using std::string;
//using std::string_view;
using std::cout;
using std::endl;



static uint32_t alloc = 0;
void* operator new (size_t s)
{
    alloc++;
    std::cout << "allocated " << s << std::endl;
    return malloc(s);
}

int main()
{
    cout << "Sring_View!" << endl;
    string str1 = "aaaa";
    int* aa = new int();
    str1 += "bbb";
    str1 += "ccc";

    cout << "Alocated counter:" << alloc << endl;

    cout << str1 << endl;
    return EXIT_SUCCESS;
}

