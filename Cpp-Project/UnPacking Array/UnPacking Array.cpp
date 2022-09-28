// UnPacking Array.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using std::cout;
int main()
{
    int values[3] = {10, 20, 30};
    auto [x, y, z] = values;    // c++17

    cout << x << ", " << y << ", " << z;

    return EXIT_SUCCESS;
}
