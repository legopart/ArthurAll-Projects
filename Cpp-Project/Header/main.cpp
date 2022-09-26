
#include <iostream>
#include "Prime.h"
#include <iomanip>
int main()
{
    Prime prime{13};
    std::cout << std::left << std::setfill('.');
    int colwith = 10;
    std::cout << std::setw(colwith) << prime.getNumber() << (prime.isPrime ? "is prime" : "not prime") << "\n";
    return EXIT_SUCCESS;

}
