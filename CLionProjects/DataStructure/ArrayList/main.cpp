
#include <iostream>
#include "Array1.cpp"
#include "Array2.cpp"
int main()
{
    std::cout << "Array1\n";
    Array1* array = new Array1(5);
    array->add(5);
    array->add(2);
    array->add(1);
    array->add(3);
    array->add(7);
    array->add(3);
    array->add(7);

    std::cout << (array->contains(5) ? "true" : "false") << "\n";
    array->print();
    array->remove(2);
    array->print();
    std::cout << "\n";


    std::cout << "Array2\n";
    Array2<int>* array2 = new Array2<int>(5);
    array2->add(5);
    array2->add(2);
    array2->add(1);
    array2->add(3);
    array2->add(7);
    array2->add(3);
    array2->add(7);

    std::cout << (array->contains(5) ? "true" : "false") << "\n";
    array2->print();
    array2->remove(2);
    array2->print();
    std::cout << "\n";
}
