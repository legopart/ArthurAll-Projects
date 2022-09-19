#include <iostream>

struct A{
    int x;
    A(int x){this->x = x;}
};

int main() {
    int x = 1;
    int y = -1;

    std::cout << (false, ++x) << std::endl;

    std::cout << x << std::endl;
    std::cout << y << std::endl;

    return 0;
}
