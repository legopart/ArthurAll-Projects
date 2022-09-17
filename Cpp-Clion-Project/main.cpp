#include <iostream>

struct A{
    int x;
    A(int x){this->x = x;}
};

int main() {
    std::cout << "out scope1:" << std::endl;
    A* ptr = NULL;
    //std::cout << "*ptr= " << *ptr << std::endl; //fail

    {
        std::cout << "in scope1:" << std::endl;
        A* a= new A(5);
        std::cout << "x= " << a->x << std::endl;   //5
        ptr = a;
        std::cout << "*ptr= " << ptr->x << std::endl; //5
    }

    std::cout << "out scope2:" << std::endl;
    std::cout << "*ptr= " << ptr->x << std::endl;




    return 0;
}
